using MediatR;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Application.CQRS.Queries;

public class GetApplicationsQuery : IRequest<IEnumerable<GetApplicationResponse>>;