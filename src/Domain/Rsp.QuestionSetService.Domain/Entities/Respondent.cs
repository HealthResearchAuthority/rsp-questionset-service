namespace Rsp.QuestionSetService.Domain.Entities;

public class Respondent
{
    public int RespondentId { get; set; }
    public string Name { get; set; } = null!;
    public string Role { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Version { get; set; }

    // Navigation properties
    public List<RespondentAnswer> RespondentAnswers { get; set; } = [];
}