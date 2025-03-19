using Ardalis.Specification;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Contracts.Repositories;

/// <summary>
/// Questions repository interface
/// </summary>
public interface IQuestionRepository
{
    /// <summary>
    /// Gets a question using the provided specification i.e. questionId = value
    /// </summary>
    /// <param name="specification"><see cref="QuestionSpecification"/></param>
    Task<Question?> GetQuestion(ISpecification<Question> specification);

    /// <summary>
    /// Gets all questions using the provided specification
    /// </summary>
    /// <param name="specification"><see cref="QuestionSpecification"/></param>
    Task<IEnumerable<Question>> GetQuestions(ISpecification<Question> specification);

    /// <summary>
    /// Adds a question to the database
    /// </summary>
    /// <param name="entity">Question entity</param>
    Task AddQuestion(Question entity);

    /// <summary>
    /// Updates an existing question in the database
    /// </summary>
    /// <param name="entity">Question entity</param>
    Task UpdateQuestion(Question entity);

    /// <summary>
    /// Deletes a question from the database
    /// </summary>
    /// <param name="questionId">Id of the question to be deleted</param>
    Task DeleteQuestion(string questionId);

    /// <summary>
    /// Undeletes a soft deleted question in the database
    /// </summary>
    /// <param name="questionId">The id of the soft deleted question to be undeleted</param>
    Task UndeleteQuestion(string questionId);

    /// <summary>
    /// Gets all question set versions
    /// </summary>
    Task<IEnumerable<Domain.Entities.Version>> GetVersions();

    /// <summary>
    /// Creates a draft question set version in the database
    /// </summary>
    /// <param name="version">Draft question set version entity</param>
    Task CreateDraftVersion(Domain.Entities.Version version);

    /// <summary>
    /// Deletes the draft version of the question set
    /// </summary>
    Task DeleteDraftVersion();

    /// <summary>
    /// Publishes a version of the question set
    /// </summary>
    /// <param name="versionId">Id of the question set version to be published</param>
    Task PublishVersion(string versionId);

    /// <summary>
    /// Adds a collection of records to the QuestionCategories table
    /// </summary>
    Task AddQuestionCategories(IEnumerable<QuestionCategory> categories);

    /// <summary>
    /// Adds a collection of records to the Questions table
    /// </summary>
    Task AddQuestions(IEnumerable<Question> questions);
}