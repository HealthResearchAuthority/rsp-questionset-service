using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Contracts.Repositories;

public interface IQuestionRepository
{
    Task<Question?> GetById(string id);

    Task<IEnumerable<Question>> GetQuestions(string categoryId);

    Task AddQuestion(Question entity);

    Task UpdateQuestion(Question entity);

    Task DeleteQuestion(string questionId);

    Task CreateQuestions(IEnumerable<Question> adaptedQuestions);
}