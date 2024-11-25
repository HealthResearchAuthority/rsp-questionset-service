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

    Task ClearAllEntities();

    Task PopulateAnswerOptions(IEnumerable<AnswerOption> answerOptions);

    Task PopulateQuestionCategories(IEnumerable<QuestionCategory> categories);

    Task PopulateQuestionSections(IEnumerable<QuestionSection> sections);

    Task PopulateQuestions(IEnumerable<Question> questions);
}