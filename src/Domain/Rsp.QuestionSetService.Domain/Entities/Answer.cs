namespace Rsp.QuestionSetService.Domain.Entities;

public class Answer
{
    public int AnswerId { get; set; }
    public string QuestionId { get; set; } = null!;
    public string AnswerOptionId { get; set; } = null!;
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
    public string? Version { get; set; }

    public AnswerOption AnswerOption { get; set; } = null!;
}