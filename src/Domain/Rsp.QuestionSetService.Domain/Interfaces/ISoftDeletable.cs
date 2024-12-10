namespace Rsp.QuestionSetService.Domain.Interfaces;

public interface ISoftDeletable
{
    bool IsDeleted { get => false; set { } }
    DateTimeOffset? DeletedAt { get => null; set { } }

    void Undo()
    {
        IsDeleted = false;
        DeletedAt = null;
    }
}