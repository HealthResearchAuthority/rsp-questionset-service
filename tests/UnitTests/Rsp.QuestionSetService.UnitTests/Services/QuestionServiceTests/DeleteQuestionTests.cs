using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class DeleteQuestionTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task DeleteQuestion_ShouldCallRepositoryDeleteQuestion(string questionId)
    {
        // Act
        await Sut.DeleteQuestion(questionId);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.DeleteQuestion(questionId), Times.Once);
    }
}