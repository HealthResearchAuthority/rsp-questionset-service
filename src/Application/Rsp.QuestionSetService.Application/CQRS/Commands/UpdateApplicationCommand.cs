using MediatR;
using Rsp.QuestionSetService.Application.DTOS.Requests;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Commands;

public class UpdateApplicationCommand(CreateApplicationRequest createApplicationRequest) : IRequest<CreateApplicationResponse>
{
    public CreateApplicationRequest CreateApplicationRequest { get; set; } = createApplicationRequest;
}