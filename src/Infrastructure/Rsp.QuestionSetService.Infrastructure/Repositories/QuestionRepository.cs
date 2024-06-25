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
}