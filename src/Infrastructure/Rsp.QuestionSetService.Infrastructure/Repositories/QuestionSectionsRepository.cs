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

    /// <inheritdoc />
    public async Task<QuestionSection?> GetNextQuestionSection(string sectionId)
    {
        // Retrieve all sections ordered correctly
        var allSections = await context.QuestionSections
            .OrderBy(qs => qs.QuestionCategoryId)
            .ThenBy(qs => qs.SectionId)
            .ToListAsync(); // Fetch all into memory

        // Assign a temporary ID based on the order
        var orderedSections = allSections
            .Select((qs, index) => new { Section = qs, TempId = index })
            .ToList();

        // Find the current section based on sectionId
        var currentSectionEntry = orderedSections.FirstOrDefault(q => q.Section.SectionId == sectionId);

        if (currentSectionEntry == null || currentSectionEntry.TempId == orderedSections.Count - 1)
        {
            return null; // No next section available (last item in list)
        }

        // Get the next section using TempId
        return orderedSections[currentSectionEntry.TempId + 1].Section;
    }

    /// <inheritdoc />
    public async Task<QuestionSection?> GetPreviousQuestionSection(string sectionId)
    {
        // Retrieve all sections ordered correctly
        var allSections = await context.QuestionSections
            .OrderBy(qs => qs.QuestionCategoryId)
            .ThenBy(qs => qs.SectionId)
            .ToListAsync(); // Fetch all into memory

        // Assign a temporary ID based on the order
        var orderedSections = allSections
            .Select((qs, index) => new { Section = qs, TempId = index })
            .ToList();

        // Find the current section based on sectionId
        var currentSectionEntry = orderedSections.FirstOrDefault(q => q.Section.SectionId == sectionId);

        if (currentSectionEntry == null || currentSectionEntry.TempId == 0)
        {
            return null; // No previous section available
        }

        // Get the previous section using TempId
        return orderedSections[currentSectionEntry.TempId - 1].Section;
    }
}