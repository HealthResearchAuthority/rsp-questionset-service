using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Infrastructure.Repositories;

/// <summary>
///     Question Section repository
/// </summary>
/// <param name="context">
///     <see cref="QuestionSetDbContext" />
/// </param>
public class QuestionSectionsRepository(QuestionSetDbContext context) : IQuestionSectionsRepository
{
    /// <inheritdoc />
    public async Task<IEnumerable<QuestionSection>> GetQuestionSections()
    {
        return await context
            .QuestionSections
            .ToListAsync();
    }

    public async Task<QuestionSection?> GetNextQuestionSection(ISpecification<QuestionSection> specification)
    {
        var allSections = await GetQuestionSections();

        // Retrieve the current section entry
        var currentSectionEntry = await context
            .QuestionSections
            .WithSpecification(specification)
            .FirstOrDefaultAsync();

        if (currentSectionEntry != null)
        {
            // Find the index of the current section in the original list
            var questionSections = allSections.ToList();
            var currentIndex = questionSections.FindIndex(s => s.SectionId == currentSectionEntry.SectionId);

            // Get the next section if there is one
            return currentIndex >= 0 && currentIndex < questionSections.Count - 1
                ? questionSections[currentIndex + 1]
                : null;
        }

        return null;
    }


    public async Task<QuestionSection?> GetPreviousQuestionSection(ISpecification<QuestionSection> specification)
    {
        var allSections = await GetQuestionSections();

        // Retrieve the current section entry
        var currentSectionEntry = await context
            .QuestionSections
            .WithSpecification(specification)
            .FirstOrDefaultAsync();

        if (currentSectionEntry != null)
        {
            // Find the index of the current section in the original list
            var questionSections = allSections.ToList();
            var currentIndex = questionSections.ToList().FindIndex(s => s.SectionId == currentSectionEntry.SectionId);

            // Get the previous section if there is one
            return currentIndex > 0 ? questionSections[currentIndex - 1] : null;
        }

        return null;
    }
}