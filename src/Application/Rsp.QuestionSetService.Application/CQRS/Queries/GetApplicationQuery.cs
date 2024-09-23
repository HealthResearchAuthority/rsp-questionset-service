using MediatR;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Queries;

public class GetApplicationQuery(string id) : IRequest<GetApplicationResponse>
{
    public string ApplicationId { get; } = id;
}