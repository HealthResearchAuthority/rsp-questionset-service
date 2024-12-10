using Rsp.Logging.Interceptors;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.Contracts.Services;

/// <summary>
/// Questionset service interface. Marked as IInterceptable to enable
/// the start/end logging for all methods.
/// </summary>
public interface IQuestionService : IInterceptable
{
    /// <summary>
    /// Gets all questions
    /// </summary>
    Task<IEnumerable<QuestionDto>> GetQuestions();

    /// <summary>
    /// Gets all questions for the category
    /// </summary>
    /// <param name="categoryId">Category Id of the questions</param>
    Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId);

    /// <summary>
    /// Clears the database and recreates based on provided question set
    /// </summary>
    /// <param name="questionSet">A collection of categories, sections, questions, and answer options</param>
    Task CreateQuestions(QuestionSetDto questionSet);

    /// <summary>
    /// Adds a question to the database
    /// </summary>
    /// <param name="entity">The question entity to be added</param>
    Task AddQuestion(QuestionDto entity);

    /// <summary>
    /// Soft deletes a question in the database
    /// </summary>
    /// <param name="questionId">The id of the question to be soft deleted</param>
    Task DeleteQuestion(string questionId);

    /// <summary>
    /// Undeletes a soft deleted question in the database
    /// </summary>
    /// <param name="questionId">The id of the soft deleted question to be undeleted</param>
    Task UndeleteQuestion(string questionId);
}