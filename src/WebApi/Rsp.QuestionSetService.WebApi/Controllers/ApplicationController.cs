using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.CQRS.Commands;
using Rsp.QuestionSetService.Application.CQRS.Queries;
using Rsp.QuestionSetService.Application.DTOS.Requests;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApplicationsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    [Produces<GetApplicationResponse>]
    public async Task<ActionResult<GetApplicationResponse>> GetApplication(string id)
    {
        var query = new GetApplicationQuery(id);

        var response = await mediator.Send(query);

        if (response == null)
        {
            return NotFound(response);
        }

        return Ok(response);
    }

    [HttpGet("all")]
    [Produces<IEnumerable<GetApplicationResponse>>]
    public async Task<IEnumerable<GetApplicationResponse>> GetApplications()
    {
        var query = new GetApplicationsQuery();

        return await mediator.Send(query);
    }

    [HttpGet("{status}")]
    public async Task<GetApplicationResponse> GetApplicationByStatus(string id, string status)
    {
        var request = new GetApplicationWithStatusQuery(id)
        {
            ApplicationStatus = status
        };

        return await mediator.Send(request);
    }

    [HttpGet("{status}/all")]
    public async Task<IEnumerable<GetApplicationResponse>> GetApplicationsByStatus(string status)
    {
        var request = new GetApplicationsWithStatusQuery
        {
            ApplicationStatus = status
        };

        return await mediator.Send(request);
    }

    [HttpPost]
    public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest createApplicationRequest)
    {
        var request = new CreateApplicationCommand(createApplicationRequest);

        return await mediator.Send(request);
    }

    [HttpPost("update")]
    public async Task<CreateApplicationResponse> UpdateApplication(CreateApplicationRequest irasApplicationRequest)
    {
        var request = new UpdateApplicationCommand(irasApplicationRequest);

        return await mediator.Send(request);
    }

    [HttpDelete]
    public async Task DeleteApplication(string applicationId)
    {
        var request = new DeleteApplicationCommand(applicationId);

        await mediator.Send(request);
    }
}