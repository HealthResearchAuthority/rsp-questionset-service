namespace Rsp.QuestionSetService.Application.DTOS.Responses;

public record QuestionSetDto
{
    public IEnumerable<CategoryDto> Categories { get; set; } = [];
    public IEnumerable<SectionDto> Sections { get; set; } = [];
    public IEnumerable<AnswerOptionDto> AnswerOptions { get; set; } = [];
    public IEnumerable<QuestionDto> Questions { get; set; } = [];
}