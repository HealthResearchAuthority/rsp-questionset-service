using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class DeleteDraftVersionTest : TestServiceBase<QuestionService>
{
    [Fact]
    public async Task DeleteDraftVersion_ShouldCallRepository()
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.DeleteDraftVersion())
            .Returns(Task.CompletedTask);

        // Act
        await Sut.DeleteDraftVersion();

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.DeleteDraftVersion(), Times.Once);
    }

    [Fact]
    public async Task DeleteDraftVersion_ShouldHandleRepositoryException()
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.DeleteDraftVersion())
            .ThrowsAsync(new Exception("Repository error"));

        // Act & Assert
        await Should.ThrowAsync<Exception>(Sut.DeleteDraftVersion());
    }
}