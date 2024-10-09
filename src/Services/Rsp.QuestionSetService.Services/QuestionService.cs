using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Application.Specifications;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    /// <summary>
    /// Gets all questions
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions()
    {
        // specification with parameters will include all questions
        var questions = await questionRepository.GetQuestions(new QuestionSpecification());

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    /// <summary>
    /// Gets all questions for a category
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId)
    {
        // passing specification with categoryId parameter to get all questions for that category
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(categoryId: categoryId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }
}