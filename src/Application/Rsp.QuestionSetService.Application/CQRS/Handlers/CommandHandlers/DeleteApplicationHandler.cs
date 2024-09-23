using MediatR;
using Microsoft.Extensions.Logging;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.CQRS.Commands;

namespace Rsp.QuestionSetService.Application.CQRS.Handlers.CommandHandlers;

public class DeleteApplicationHandler(ILogger<DeleteApplicationHandler> logger, IResearchApplicationService applicationsService) : IRequestHandler<DeleteApplicationCommand>
{
    public async Task Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating IRAS application");

        await applicationsService.DeleteApplication(request.ApplicationId);
    }
}