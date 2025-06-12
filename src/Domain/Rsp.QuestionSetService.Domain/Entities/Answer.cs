using System.ComponentModel.DataAnnotations.Schema;

namespace Rsp.QuestionSetService.Domain.Entities;

public class Answer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AnswerId { get; set; }

    public string QuestionId { get; set; } = null!;
    public string AnswerOptionId { get; set; } = null!;
    public string VersionId { get; set; } = null!;
    public AnswerOption AnswerOption { get; set; } = null!;
}