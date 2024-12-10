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
    /// Delete contents all tables in the database
    /// </summary>
    Task ClearAllEntities();

    /// <summary>
    /// Populates the AnswerOptions table
    /// </summary>
    Task PopulateAnswerOptions(IEnumerable<AnswerOption> answerOptions);

    /// <summary>
    /// Populates the QuestionCategories table
    /// </summary>
    Task PopulateQuestionCategories(IEnumerable<QuestionCategory> categories);

    /// <summary>
    /// Populates the QuestionSections table
    /// </summary>
    Task PopulateQuestionSections(IEnumerable<QuestionSection> sections);

    /// <summary>
    /// Populates the Questions table
    /// </summary>
    Task PopulateQuestions(IEnumerable<Question> questions);
}