namespace Rsp.QuestionSetService.Application.CQRS.Queries;

public class GetApplicationsWithStatusQuery : GetApplicationsQuery
{
    public string ApplicationStatus { get; set; } = null!;
}