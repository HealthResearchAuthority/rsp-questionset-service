using Ardalis.Specification;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Specifications;

/// <summary>
/// Represents the specification to get question(s) by question/category or all.
/// </summary>
public class QuestionSpecification : Specification<Question>
{
    public QuestionSpecification(string? questionId = null, string? categoryId = null)
    {
        var builder = Query
            .AsNoTracking()
            .AsSplitQuery()
            .Include(q => q.QuestionSection)
            .Include(q => q.Answers)
            .ThenInclude(ans => ans.AnswerOption)
            .Include(q => q.QuestionRules);

        // add a clause if questionId is not null
        if (questionId != null)
        {
            builder
                .Where(q => q.QuestionId == questionId);
        }

        // add a clause if categoryId is not null
        if (categoryId != null)
        {
            builder
                .Where(q => q.QuestionCategoryId == categoryId);
        }
    }
}