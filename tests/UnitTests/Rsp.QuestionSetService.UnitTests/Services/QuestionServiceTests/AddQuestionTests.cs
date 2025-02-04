using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class AddQuestionTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task AddQuestion_ShouldAdaptAndAddQuestion(QuestionDto questionDto)
    {
        // Arrange
        var adaptedQuestion = questionDto.Adapt<Question>();

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.AddQuestion(It.IsAny<Question>()))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.AddQuestion(questionDto);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.AddQuestion(It.Is<Question>(q =>
                q.QuestionId == adaptedQuestion.QuestionId &&
                q.QuestionText == adaptedQuestion.QuestionText &&
                q.QuestionCategoryId == adaptedQuestion.QuestionCategoryId &&
                q.QuestionSectionId == adaptedQuestion.QuestionSectionId
            )), Times.Once);
    }

    [Theory, AutoData]
    public async Task AddQuestion_ShouldHandleRepositoryException(QuestionDto questionDto)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.AddQuestion(It.IsAny<Question>()))
            .ThrowsAsync(new Exception("Repository error"));

        // Act & Assert
        await Should.ThrowAsync<Exception>(async () => await Sut.AddQuestion(questionDto));
    }
}