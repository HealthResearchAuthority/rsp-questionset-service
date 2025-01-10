namespace Rsp.QuestionSetService.Application.DTOS.Responses;

public record CategoryDto
{
    public string CategoryId { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string VersionId { get; set; } = null!;
}