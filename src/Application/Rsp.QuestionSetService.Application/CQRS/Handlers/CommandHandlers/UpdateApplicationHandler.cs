using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Commands;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.CommandHandlers;

public class UpdateApplicationHandler(ILogger<UpdateApplicationHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<UpdateApplicationCommand, CreateApplicationResponse>
{
    public async Task<CreateApplicationResponse> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Update IRAS application with ID: {Id}", request.CreateApplicationRequest.ApplicationId);

        return await applicationsService.UpdateResearchApplication(request.CreateApplicationRequest);
    }
}