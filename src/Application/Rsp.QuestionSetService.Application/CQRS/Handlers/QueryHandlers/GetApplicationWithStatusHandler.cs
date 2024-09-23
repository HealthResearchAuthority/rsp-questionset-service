using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.Logging.Extensions;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Queries;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.QueryHandlers;

public class GetApplicationWithStatusHandler(ILogger<GetApplicationWithStatusHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<GetApplicationWithStatusQuery, GetApplicationResponse>
{
    public async Task<GetApplicationResponse> Handle(GetApplicationWithStatusQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformationHp(nameof(request.ApplicationId), "Getting application with ID");

        return await applicationsService.GetApplication(request.ApplicationId, request.ApplicationStatus);
    }
}