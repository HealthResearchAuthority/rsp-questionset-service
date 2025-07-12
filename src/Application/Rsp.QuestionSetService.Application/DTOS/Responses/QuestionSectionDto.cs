namespace Rsp.QuestionSetService.Application.DTOS.Responses;

public record QuestionSectionDto
{
    public string QuestionCategoryId { get; set; } = null!;
    public string SectionId { get; set; } = null!;
    public string SectionName { get; set; } = null!;
    public string VersionId { get; set; } = null!;
}