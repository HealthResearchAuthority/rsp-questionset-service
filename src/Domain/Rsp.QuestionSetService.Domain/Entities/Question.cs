using Rsp.QuestionSetService.Domain.Interfaces;

namespace Rsp.QuestionSetService.Domain.Entities;

public class Question : ISoftDeletable
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
    public string VersionId { get; set; } = null!;
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    // Navigation properties
    public QuestionSection QuestionSection { get; set; } = null!;

    public ICollection<Answer> Answers { get; set; } = [];
    public ICollection<QuestionRule> QuestionRules { get; set; } = [];
    public string? ShortQuestionText { get; set; }
}