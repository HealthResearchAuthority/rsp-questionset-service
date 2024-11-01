using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController(IQuestionService questionService) : ControllerBase
{
    [HttpGet]
    [Produces<IEnumerable<QuestionDto>>]
    public async Task<IEnumerable<QuestionDto>> GetQuestions()
    {
        return await questionService.GetQuestions("A");
    }

    [HttpGet("next")]
    [Produces<IEnumerable<QuestionDto>>]
    public async Task<IEnumerable<QuestionDto>> GetNextQuestions(string category)
    {
        return await questionService.GetQuestions(category);
    }

    [HttpPost]
    public async Task CreateQuestions(IEnumerable<QuestionDto> questions)
    {
        await questionService.CreateQuestions(questions);
    }

    [HttpPost("add")]
    public async Task AddQuestion(QuestionDto question)
    {
        await questionService.AddQuestion(question);
    }
}