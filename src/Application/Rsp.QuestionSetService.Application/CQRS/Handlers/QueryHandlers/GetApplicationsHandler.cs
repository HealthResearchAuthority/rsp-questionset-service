using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Queries;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.QueryHandlers;

public class GetApplicationsHandler(ILogger<GetApplicationsHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<GetApplicationsQuery, IEnumerable<GetApplicationResponse>>
{
    public async Task<IEnumerable<GetApplicationResponse>> Handle(GetApplicationsQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting all applications");

        return await applicationsService.GetApplications();
    }
}