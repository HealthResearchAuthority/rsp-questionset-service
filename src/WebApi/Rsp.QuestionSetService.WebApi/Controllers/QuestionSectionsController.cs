using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionSectionsController(IQuestionSectionsService questionSectionsService) : ControllerBase
{
    /// <summary>
    ///     Gets all questions or filters by category and section if provided
    /// </summary>
    [HttpGet("all")]
    public async Task<IEnumerable<QuestionSectionDto>> GetQuestionSections()
    {
        return await questionSectionsService.GetQuestionSections();
    }

    [HttpGet("next")]
    public async Task<ActionResult<QuestionSectionDto>> GetNextQuestionSection([FromQuery] string sectionId)
    {
        return await questionSectionsService.GetNextQuestionSections(sectionId);
    }

    [HttpGet("previous")]
    public async Task<ActionResult<QuestionSectionDto>> GetPreviousQuestionSection([FromQuery] string sectionId)
    {
        return await questionSectionsService.GetPreviousQuestionSections(sectionId);
    }
}