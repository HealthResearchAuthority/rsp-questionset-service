namespace Rsp.QuestionSetService.Domain.Entities;

public class Version
{
    public string VersionId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string? PublishedBy { get; set; }
    public DateTime? PublishedAt { get; set; }
    public bool IsDraft { get; set; }
    public bool IsPublished { get; set; }
}