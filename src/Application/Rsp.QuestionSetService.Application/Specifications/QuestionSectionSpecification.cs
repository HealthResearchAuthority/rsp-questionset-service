using Ardalis.Specification;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Specifications;

/// <summary>
/// Represents the specification to get question(s) by question/category or all.
/// </summary>
public class QuestionSectionSpecification : Specification<QuestionSection>
{
    public QuestionSectionSpecification(string? sectionId = null)
    {
        var builder = Query
            .Where(x => x.IsActive)
            .AsNoTracking()
            .AsSplitQuery();

        if (sectionId != null)
        {
            builder.Where(q => q.SectionId == sectionId);
        }
    }
}