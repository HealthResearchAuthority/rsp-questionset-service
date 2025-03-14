using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class PublishVersionTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task PublishVersion_ShouldCallRepository(string versionId)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PublishVersion(It.IsAny<string>()))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.PublishVersion(versionId);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PublishVersion(It.IsAny<string>()), Times.Once);
    }

    [Theory, AutoData]
    public async Task AddQuestion_ShouldHandleRepositoryException(string versionId)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PublishVersion(It.IsAny<string>()))
            .ThrowsAsync(new Exception("Repository error"));

        // Act & Assert
        await Should.ThrowAsync<Exception>(async () => await Sut.PublishVersion(versionId));
    }
}