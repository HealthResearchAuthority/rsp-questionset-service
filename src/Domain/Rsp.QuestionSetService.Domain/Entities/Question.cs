namespace Rsp.QuestionSetService.Domain.Entities;

public class Question
{
    public string QuestionId { get; set; } = null!;
    public string QuestionCategoryId { get; set; } = null!;
    public string QuestionSectionId { get; set; } = null!;
    public int Sequence { get; set; }
    public string? Heading { get; set; }
    public string QuestionText { get; set; } = null!;
    public string QuestionType { get; set; } = null!;
    public string DataType { get; set; } = null!;
    public string Conformance { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Version { get; set; }
    public QuestionSection QuestionSection { get; set; } = null!;
    public ICollection<Answer> Answers { get; set; } = [];
    public ICollection<QuestionRule> QuestionRules { get; set; } = [];
}