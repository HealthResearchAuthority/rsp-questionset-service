using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;

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
}