namespace Rsp.QuestionSetService.Domain.Entities;

public class QuestionSection
{
    public string SectionId { get; set; } = null!;
    public string QuestionCategoryId { get; set; } = null!;
    public string SectionName { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string VersionId { get; set; } = null!;

    // Navigation properties
    public List<Question> Questions { get; set; } = [];
}