using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Commands;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.CommandHandlers;

public class CreateApplicationHandler(ILogger<CreateApplicationHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<CreateApplicationCommand, CreateApplicationResponse>
{
    public async Task<CreateApplicationResponse> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating IRAS application");

        return await applicationsService.CreateResearchApplication(request.CreateApplicationRequest);
    }
}