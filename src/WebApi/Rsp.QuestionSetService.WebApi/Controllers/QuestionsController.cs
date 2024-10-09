using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController(IQuestionService questionService) : ControllerBase
{
    /// <summary>
    /// Gets all questions or by category if provided
    /// </summary>
    [HttpGet]
    [Produces<IEnumerable<QuestionDto>>]
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string? categoryId)
    {
        return categoryId == null ?
            await questionService.GetQuestions() :
            await questionService.GetQuestions(categoryId);
    }
}