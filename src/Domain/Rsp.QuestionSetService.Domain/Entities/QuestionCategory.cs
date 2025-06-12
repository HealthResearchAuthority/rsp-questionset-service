namespace Rsp.QuestionSetService.Domain.Entities;

public class QuestionCategory
{
    public string CategoryId { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public bool IsActive { get; set; }
    public string VersionId { get; set; } = null!;

    // Navigation properties
    public List<Question> Questions { get; set; } = [];

    public List<QuestionSection> QuestionSections { get; set; } = [];
}