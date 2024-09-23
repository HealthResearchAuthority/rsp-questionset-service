namespace Rsp.QuestionSetService.Application.DTOS.Requests;

public record CreateApplicationRequest
{
    public string UserId { get; set; } = null!;
    public string ApplicationId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public string? Status { get; set; }
}