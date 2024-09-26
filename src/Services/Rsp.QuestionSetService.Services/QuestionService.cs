using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId)
    {
        var questions = await questionRepository.GetQuestions(categoryId);

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }
}