using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class UndeleteQuestionTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task UndeleteQuestion_ShouldCallRepositoryUndeleteQuestion(string questionId)
    {
        // Act
        await Sut.UndeleteQuestion(questionId);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.UndeleteQuestion(questionId), Times.Once);
    }
}