using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId)
    {
        var questions = await questionRepository.GetQuestions(categoryId);

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    public async Task CreateQuestions(IEnumerable<QuestionDto> questions)
    {
        var adaptedQuestions = questions.Adapt<IEnumerable<Question>>();

        await questionRepository.CreateQuestions(adaptedQuestions);
    }

    public async Task AddQuestion(QuestionDto entity)
    {
        var adaptedQuestion = entity.Adapt<Question>();

        await questionRepository.AddQuestion(adaptedQuestion);
    }
}