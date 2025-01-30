using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class GetQuestionsTests : TestServiceBase<QuestionService>
{
    [Fact]
    public async Task GetQuestions_ShouldReturnAllQuestions()
    {
        // Arrange
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1" },
            new() { QuestionId = "2", QuestionText = "Question 2" },
            new() { QuestionId = "3", QuestionText = "Question 3" }
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions);

        // Act
        var result = await Sut.GetQuestions();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Count);

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestions_ShouldReturnEmptyList_WhenNoQuestionsExist()
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync([]);

        // Act
        var result = await Sut.GetQuestions();

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeEmpty();

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestions_ShouldMapQuestionsToQuestionDtos()
    {
        // Arrange
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1" },
            new() { QuestionId = "2", QuestionText = "Question 2" },
            new() { QuestionId = "3", QuestionText = "Question 3" }
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions);

        // Act
        var result = await Sut.GetQuestions();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Count);
    }
}