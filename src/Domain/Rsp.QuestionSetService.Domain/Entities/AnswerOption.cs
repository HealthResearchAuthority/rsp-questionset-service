﻿namespace Rsp.QuestionSetService.Domain.Entities;

public class AnswerOption
{
    public string OptionId { get; set; } = null!;
    public string OptionText { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Version { get; set; }
}