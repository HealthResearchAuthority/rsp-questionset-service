﻿using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Infrastructure.Repositories;

/// <summary>
///     Question Category repository
/// </summary>
/// <param name="context">
///     <see cref="QuestionSetDbContext" />
/// </param>
public class QuestionCategoriesRepository(QuestionSetDbContext context) : IQuestionCategoriesRepository
{
    /// <inheritdoc />
    public async Task<IEnumerable<QuestionCategory>> GetQuestionCategories()
    {
        return await context
            .QuestionCategories
            .Where(qc => qc.IsActive) // Filter only active categories
            .ToListAsync();
    }
}