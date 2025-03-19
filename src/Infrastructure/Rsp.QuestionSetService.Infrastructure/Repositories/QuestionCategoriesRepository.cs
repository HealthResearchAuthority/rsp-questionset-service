using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IEnumerable<QuestionCategory>> GetQuestionCategories(
        ISpecification<QuestionCategory> questionSpecification)
    {
        var publishedVersion = await context.Versions.FirstOrDefaultAsync(v => v.IsPublished);

        if (publishedVersion == null)
        {
            return [];
        }

        return await context
            .QuestionCategories
            .Where(qc => qc.VersionId == publishedVersion.VersionId)
            .WithSpecification(questionSpecification)
            .ToListAsync();
    }
}