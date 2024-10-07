using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.Contracts.Services;

public interface IQuestionService
{
    Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId);

    Task CreateQuestions(IEnumerable<QuestionDto> questions);
}