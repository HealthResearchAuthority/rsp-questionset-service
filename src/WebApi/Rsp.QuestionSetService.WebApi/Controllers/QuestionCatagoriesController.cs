using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionCatagoriesController(IQuestionCategoriesService questionCategoriesService) : ControllerBase
{
    /// <summary>
    ///     Gets all questions or filters by category and section if provided
    /// </summary>
    [HttpGet("all")]
    public async Task<IEnumerable<CategoryDto>> GetQuestionSections()
    {
        return await questionCategoriesService.GetQuestionCategories();
    }
}