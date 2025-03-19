using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class AddQuestionSetTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task AddQuestionSet_ShouldPopulateEntities(QuestionSetDto questionSet)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.AddQuestionCategories(It.IsAny<IEnumerable<QuestionCategory>>()))
            .Returns(Task.CompletedTask);

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.AddQuestions(It.IsAny<IEnumerable<Question>>()))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.AddQuestionSet(questionSet);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.AddQuestionCategories(It.IsAny<IEnumerable<QuestionCategory>>()), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.AddQuestions(It.IsAny<IEnumerable<Question>>()), Times.Once);
    }

    [Theory, AutoData]
    public async Task AddQuestionSet_ShouldHandleEmptyQuestionSet(QuestionSetDto emptyQuestionSet)
    {
        // Arrange
        emptyQuestionSet.Categories = [];
        emptyQuestionSet.Questions = [];

        // Act
        await Sut.AddQuestionSet(emptyQuestionSet);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.AddQuestionCategories(It.Is<IEnumerable<QuestionCategory>>(qc => !qc.Any())), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.AddQuestions(It.Is<IEnumerable<Question>>(q => !q.Any())), Times.Once);
    }

    [Theory, AutoData]
    public async Task AddQuestionSet_ShouldHandleExceptions(QuestionSetDto questionSet)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.AddQuestionCategories(It.IsAny<IEnumerable<QuestionCategory>>()))
            .ThrowsAsync(new Exception("Test exception"));

        // Act & Assert
        await Should.ThrowAsync<Exception>(async () => await Sut.AddQuestionSet(questionSet));
    }
}