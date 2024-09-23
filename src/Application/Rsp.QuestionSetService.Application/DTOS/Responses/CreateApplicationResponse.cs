﻿namespace Rsp.QuestionSetService.Application.DTOS.Responses;

public record CreateApplicationResponse
{
    public string ApplicationId { get; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public string? Status { get; set; }
}