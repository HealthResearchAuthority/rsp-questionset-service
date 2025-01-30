using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Domain.Interfaces;

namespace Rsp.QuestionSetService.Infrastructure.Repositories;

/// <summary>
/// Questionset repository
/// </summary>
/// <param name="context"><see cref="QuestionSetDbContext"/></param>
public class QuestionRepository(QuestionSetDbContext context) : IQuestionRepository
{
    /// <inheritdoc/>
    public async Task<Question?> GetQuestion(ISpecification<Question> specification)
    {
        return await context
            .Questions
            .WithSpecification(specification)
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Question>> GetQuestions(ISpecification<Question> specification)
    {
        return await context
            .Questions
            .WithSpecification(specification)
            .ToListAsync();
    }

    /// <inheritdoc/>
    public async Task AddQuestion(Question entity)
    {
        await context.Questions.AddAsync(entity);

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task UpdateQuestion(Question entity)
    {
        context.Questions.Update(entity);

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task DeleteQuestion(string questionId)
    {
        var questionEntity = await context.Questions.FirstOrDefaultAsync(q => q.QuestionId == questionId);

        if (questionEntity != null)
        {
            context.Questions.Remove(questionEntity);
            await context.SaveChangesAsync();
        }
    }

    /// <inheritdoc/>
    public async Task UndeleteQuestion(string questionId)
    {
        var deletedQuestionEntity =
            await context.Questions
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(q => questionId == q.QuestionId && q.IsDeleted);

        if (deletedQuestionEntity is ISoftDeletable softDeletedQuestion)
        {
            softDeletedQuestion.Undo();
            await context.SaveChangesAsync();
        }
    }

    /// <inheritdoc/>
    public async Task ClearAllEntities()
    {
        await context.Answers.ExecuteDeleteAsync();
        await context.AnswerOptions.ExecuteDeleteAsync();
        await context.QuestionRules.ExecuteDeleteAsync();
        await context.Questions.IgnoreQueryFilters().ExecuteDeleteAsync();
        await context.QuestionSections.ExecuteDeleteAsync();
        await context.QuestionCategories.ExecuteDeleteAsync();
    }

    /// <inheritdoc/>
    public async Task PopulateAnswerOptions(IEnumerable<AnswerOption> answerOptions)
    {
        context.AnswerOptions.AddRange(answerOptions);
        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task PopulateQuestionCategories(IEnumerable<QuestionCategory> categories)
    {
        foreach (var category in categories)
        {
            category.IsActive = true;
            await context.QuestionCategories.AddAsync(category);
        }

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task PopulateQuestionSections(IEnumerable<QuestionSection> sections)
    {
        foreach (var questionSection in sections)
        {
            var questionCategory =
                await context.QuestionCategories
                .FirstOrDefaultAsync(c => c.CategoryId == questionSection.QuestionCategoryId);

            if (questionCategory == null)
            {
                continue;
            }

            questionSection.IsActive = true;

            context.Entry(questionCategory).State = EntityState.Unchanged; // Might be unnecessary
            context.QuestionSections.Add(questionSection);
        }

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task PopulateQuestions(IEnumerable<Question> questions)
    {
        foreach (var question in questions)
        {
            var questionSection = await context.QuestionSections
                .FirstOrDefaultAsync(s => s.SectionId == question.QuestionSectionId);

            if (questionSection == null)
            {
                continue;
            }

            // Prevent tracked entity issues
            context.Entry(questionSection).State = EntityState.Unchanged;
            question.QuestionSection = questionSection;

            // Skip question if category of QuestionSection does not match category of Question
            if (questionSection.QuestionCategoryId != question.QuestionCategoryId)
            {
                continue;
            }

            var questionCategory = await context.QuestionCategories
                .FirstOrDefaultAsync(c => c.CategoryId == question.QuestionCategoryId);

            // Skip question if provided category does not exist
            if (questionCategory == null)
            {
                continue;
            }

            // Populate answers
            foreach (var answer in question.Answers)
            {
                var answerOption = await context.AnswerOptions
                    .FirstOrDefaultAsync(o => o.OptionId == answer.AnswerOptionId);

                // Skip answer if provided answer option does not exist
                if (answerOption == null)
                {
                    continue;
                }

                context.Entry(answerOption).State = EntityState.Unchanged;
                answer.AnswerOption = answerOption;
                answer.QuestionId = question.QuestionId;
            }

            var newQuestion = question;
            newQuestion.QuestionRules = [];

            await context.Questions.AddAsync(newQuestion);
        }

        // Save all questions to generate IDs
        await context.SaveChangesAsync();

        foreach (var question in questions)
        {
            foreach (var rule in question.QuestionRules)
            {
                var parentQuestion = await context.Questions
                    .FirstOrDefaultAsync(q => q.QuestionId == rule.ParentQuestionId);

                if (parentQuestion == null)
                {
                    rule.ParentQuestionId = null;
                }

                rule.QuestionId = question.QuestionId;

                context.QuestionRules.Add(rule);
            }
        }

        // Save all rules
        await context.SaveChangesAsync();
    }
}