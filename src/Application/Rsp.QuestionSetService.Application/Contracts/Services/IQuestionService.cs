using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.Contracts.Services;

/// <summary>
/// Questionset service interface
/// </summary>
public interface IQuestionService
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

    Task CreateQuestions(QuestionSetDto questionSet);

    Task AddQuestion(QuestionDto entity);
}