namespace Rsp.QuestionSetService.Domain.Interfaces;

public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
    DateTimeOffset? DeletedAt { get; set; }

    void Undo()
    {
        IsDeleted = false;
        DeletedAt = null;
    }
}