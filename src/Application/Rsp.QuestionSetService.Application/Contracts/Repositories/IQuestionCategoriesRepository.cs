using Ardalis.Specification;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Contracts.Repositories;

/// <summary>
/// Question Sections repository interface
/// </summary>
public interface IQuestionCategoriesRepository
{

    /// <summary>
    /// Gets all questions using the provided specification
    /// </summary>
    Task<IEnumerable<QuestionCategory>> GetQuestionCategories();
}