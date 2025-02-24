using Rsp.Logging.Interceptors;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.Contracts.Services;

/// <summary>
///     Question Section service interface. Marked as IInterceptable to enable
///     the start/end logging for all methods.
/// </summary>
public interface IQuestionSectionsService : IInterceptable
{
    /// <summary>
    ///     Gets all question sections
    /// </summary>
    Task<IEnumerable<QuestionSectionDto>> GetQuestionSections();

    /// <summary>
    ///     Gets the previous question sections
    /// </summary>
    Task<QuestionSectionDto> GetPreviousQuestionSections(string currentSectionId);

    /// <summary>
    ///     Gets the next question sections
    /// </summary>
    Task<QuestionSectionDto> GetNextQuestionSections(string currentSectionId);
}