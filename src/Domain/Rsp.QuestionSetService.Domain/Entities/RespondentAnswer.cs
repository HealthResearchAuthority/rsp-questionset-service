namespace Rsp.QuestionSetService.Domain.Entities;

public class RespondentAnswer
{
    public int RespondentId { get; set; }
    public string QuestionId { get; set; } = null!;
    public int ApplicationId { get; set; }
    public string Response { get; set; } = null!;
    public string? OptionId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Version { get; set; }
}