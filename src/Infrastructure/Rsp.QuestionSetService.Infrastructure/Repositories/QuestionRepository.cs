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
    public async Task<IEnumerable<Domain.Entities.Version>> GetVersions()
    {
        return await context
            .Versions
            .ToListAsync();
    }

    /// <inheritdoc/>
    public async Task CreateDraftVersion(Domain.Entities.Version version)
    {
        await context.Versions.AddAsync(version);
        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task DeleteDraftVersion()
    {
        var draftVersion =
            await context.Versions
            .FirstOrDefaultAsync(v => v.IsDraft);

        if (draftVersion == null) return;

        await context.Answers
            .Where(a => a.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        await context.QuestionRules
            .Where(qr => qr.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        await context.Questions
            .Where(q => q.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        await context.QuestionSections
            .Where(qs => qs.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        await context.QuestionCategories
            .Where(qc => qc.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        await context.AnswerOptions
            .Where(ao => ao.VersionId == draftVersion.VersionId)
            .ExecuteDeleteAsync();

        context.Versions.Remove(draftVersion);

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task PublishVersion(string versionId)
    {
        var version =
            await context.Versions
            .FirstOrDefaultAsync(v => v.VersionId == versionId);

        if (version == null) return;

        var publishedVersion =
            await context.Versions
            .FirstOrDefaultAsync(v => v.IsPublished);

        if (publishedVersion != null)
        {
            publishedVersion.IsPublished = false;
            publishedVersion.PublishedAt = null;
            publishedVersion.PublishedBy = null;
        }

        version.IsDraft = false;
        version.IsPublished = true;
        version.PublishedAt = DateTime.UtcNow;
        version.PublishedBy = "admin";

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task AddQuestionCategories(IEnumerable<QuestionCategory> categories)
    {
        foreach (var category in categories)
        {
            category.IsActive = true;
            await context.QuestionCategories.AddAsync(category);
        }

        await context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public async Task AddQuestions(IEnumerable<Question> questions)
    {
        foreach (var question in questions)
        {
            // Check if question.QuestionSection is already tracked
            var trackedSection =
                context.ChangeTracker
                .Entries<QuestionSection>()
                .SingleOrDefault(s => s.Entity.SectionId == question.QuestionSectionId && s.Entity.VersionId == question.VersionId)?
                .Entity;

            // Set question.QuestionSection to the tracked one to prevent tracked entity issues
            if (trackedSection != null)
            {
                question.QuestionSection = trackedSection;
            }

            foreach (var answer in question.Answers)
            {
                // Repeat above for all answer.AnswerOption
                var trackedAnswerOption =
                    context.ChangeTracker
                    .Entries<AnswerOption>()
                    .SingleOrDefault(ao => ao.Entity.OptionId == answer.AnswerOptionId && ao.Entity.VersionId == answer.VersionId)?
                    .Entity;

                answer.QuestionId = question.QuestionId;

                if (trackedAnswerOption != null)
                {
                    answer.AnswerOption = trackedAnswerOption;
                }
            }

            await context.Questions.AddAsync(question);
        }

        await context.SaveChangesAsync();
    }
}