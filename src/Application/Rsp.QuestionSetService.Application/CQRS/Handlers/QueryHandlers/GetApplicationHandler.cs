using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Queries;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.QueryHandlers;

public class GetApplicationHandler(ILogger<GetApplicationHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<GetApplicationQuery, GetApplicationResponse>
{
    public async Task<GetApplicationResponse> Handle(GetApplicationQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting application with ID = {Id}", request.ApplicationId);

        return await applicationsService.GetApplication(request.ApplicationId);
    }
}