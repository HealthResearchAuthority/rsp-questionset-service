namespace Rsp.QuestionSetService.Domain.Entities;

public class ResearchApplication
{
    public int ApplicationId { get; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public string? Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string CreatedBy { get; set; } = null!;
    public string UpdatedBy { get; set; } = null!;
}