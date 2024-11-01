using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Infrastructure.Repositories;

public class QuestionRepository(QuestionSetDbContext context) : IQuestionRepository
{
    private readonly QuestionSetDbContext _context = context;

    public async Task<Question?> GetById(string id)
    {
        return await _context
            .Questions
            .AsNoTracking()
            .AsSplitQuery()
            .Include(q => q.QuestionSection)
            .Include(q => q.Answers)
            .ThenInclude(ans => ans.AnswerOption)
            .Include(q => q.QuestionRules)
            .FirstOrDefaultAsync(q => q.QuestionId == id);
    }

    public async Task<IEnumerable<Question>> GetQuestions(string categoryId)
    {
        return await _context
            .Questions
            .AsNoTracking()
            .AsSplitQuery()
            .Where(q => q.QuestionCategoryId == categoryId)
            .Include(q => q.QuestionSection)
            .Include(q => q.Answers)
            .ThenInclude(ans => ans.AnswerOption)
            .Include(q => q.QuestionRules)
            .ToListAsync();
    }

    public async Task AddQuestion(Question entity)
    {
        await _context.Questions.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateQuestion(Question entity)
    {
        _context.Questions.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteQuestion(string questionId)
    {
        var questionEntity = await _context.Questions.FirstOrDefaultAsync(q => q.QuestionId == questionId);
        if (questionEntity != null)
        {
            _context.Questions.Remove(questionEntity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task CreateQuestions(IEnumerable<Question> adaptedQuestions)
    {
        foreach (Question question in adaptedQuestions)
        {
            var existingQuestion =
                await _context.Questions
                .Include(q => q.QuestionRules)
                .Include(q => q.Answers)
                .FirstOrDefaultAsync(q => q.QuestionId == question.QuestionId);

            if (existingQuestion == null)
            {
                await _context.Questions.AddAsync(question);
                continue;
            }

            if (existingQuestion.QuestionRules.Count == 0)
            {
                existingQuestion.QuestionRules = question.QuestionRules;
            }

            existingQuestion.QuestionCategoryId = question.QuestionCategoryId;
            existingQuestion.QuestionSectionId = question.QuestionSectionId;
            existingQuestion.Sequence = question.Sequence;
            existingQuestion.Heading = question.Heading;
            existingQuestion.QuestionText = question.QuestionText;
            existingQuestion.QuestionType = question.QuestionType;
            existingQuestion.DataType = question.DataType;
            existingQuestion.Conformance = question.Conformance;
            existingQuestion.Answers = question.Answers;
            existingQuestion.QuestionRules = existingQuestion.QuestionRules;
        }

        await _context.SaveChangesAsync();
    }
}