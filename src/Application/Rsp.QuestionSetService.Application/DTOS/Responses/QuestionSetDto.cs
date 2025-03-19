namespace Rsp.QuestionSetService.Application.DTOS.Responses;

public record QuestionSetDto
{
    public VersionDto Version { get; set; } = null!;
    public IEnumerable<CategoryDto> Categories { get; set; } = [];
    public IEnumerable<QuestionDto> Questions { get; set; } = [];
}