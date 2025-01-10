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
    /// Gets all questions for the category and section
    /// </summary>
    /// <param name="categoryId">Category Id of the questions</param>
    /// <param name="sectionId">Section Id of the questions</param>
    Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId, string? sectionId);

    /// <summary>
    /// Gets all questions for a version
    /// </summary>
    /// <param name="versionId">Version of the questions</param>
    Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId);

    /// <summary>
    /// Gets all questions for a version for the category
    /// </summary>
    /// <param name="versionId">Version of the questions</param>
    /// <param name="categoryId">Category Id of the questions</param>
    Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId, string categoryId);

    /// <summary>
    /// Adds a question set to the database
    /// </summary>
    /// <param name="questionSet">A collection of categories, sections, questions, and answer options</param>
    Task AddQuestionSet(QuestionSetDto questionSet);

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

    /// <summary>
    /// Gets all question set versions
    /// </summary>
    Task<IEnumerable<VersionDto>> GetVersions();

    /// <summary>
    /// Deletes a draft version (if one exists) and creates a draft question set version
    /// </summary>
    /// <param name="version">The draft version entity to be created</param>
    Task CreateDraftVersion(VersionDto version);

    /// <summary>
    /// Deletes a draft version (if one exists)
    /// </summary>
    Task DeleteDraftVersion();

    /// <summary>
    /// Publishes a queston set version
    /// </summary>
    /// <param name="versionId">The id of the version to publish</param>
    Task PublishVersion(string versionId);
}