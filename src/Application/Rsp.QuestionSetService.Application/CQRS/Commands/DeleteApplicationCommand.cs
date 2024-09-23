using MediatR;

namespace Rsp.QuestionSetService.Application.CQRS.Commands;

public class DeleteApplicationCommand(string applicationId) : IRequest
{
    public string ApplicationId { get; set; } = applicationId;
}