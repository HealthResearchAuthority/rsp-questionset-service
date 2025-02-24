using Rsp.Logging.Interceptors;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.Contracts.Services;

/// <summary>
///     Question Section service interface. Marked as IInterceptable to enable
///     the start/end logging for all methods.
/// </summary>
public interface IQuestionCategoriesService : IInterceptable
{
    /// <summary>
    ///     Gets all question categories
    /// </summary>
    Task<IEnumerable<CategoryDto>> GetQuestionCategories();
}