using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Queries;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.QueryHandlers;

public class GetApplicationsWithStatusHandler(ILogger<GetApplicationsWithStatusHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<GetApplicationsWithStatusQuery, IEnumerable<GetApplicationResponse>>
{
    public async Task<IEnumerable<GetApplicationResponse>> Handle(GetApplicationsWithStatusQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting all applications");

        return await applicationsService.GetApplications(request.ApplicationStatus);
    }
}