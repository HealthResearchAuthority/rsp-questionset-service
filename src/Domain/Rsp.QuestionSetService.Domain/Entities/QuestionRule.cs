namespace Rsp.QuestionSetService.Domain.Entities;

public class QuestionRule
{
    public int RuleId { get; set; }
    public int Sequence { get; set; }
    public string Operator { get; set; } = null!;
    public string QuestionId { get; set; } = null!;
    public string ParentQuestionId { get; set; } = null!;
    public string Description { get; set; } = null!;
    public Condition Condition { get; set; } = null!;
}