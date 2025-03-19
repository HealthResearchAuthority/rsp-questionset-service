namespace Rsp.QuestionSetService.Domain.Entities;

public class QuestionCategory
{
    public string CategoryId { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string VersionId { get; set; } = null!;

    // Navigation properties
    public List<Question> Questions { get; set; } = [];

    public List<QuestionSection> QuestionSections { get; set; } = [];
}