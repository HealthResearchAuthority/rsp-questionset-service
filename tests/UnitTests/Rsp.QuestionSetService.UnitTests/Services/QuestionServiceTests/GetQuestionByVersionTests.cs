using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class GetQuestionByVersionTests : TestServiceBase<QuestionService>
{
    [Fact]
    public async Task GetQuestionsByVersion_ShouldReturnAllQuestions_ForTheGivenVersion()
    {
        // Arrange
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1", VersionId = "v1" },
            new() { QuestionId = "2", QuestionText = "Question 2", VersionId = "v1" },
            new() { QuestionId = "3", QuestionText = "Question 3", VersionId = "v2" }
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions.Where(q => q.VersionId == "v1"));

        // Act
        var result = await Sut.GetQuestionsByVersion("v1");

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Where(q => q.VersionId == "v1").Count());

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestionsByVersion_ShouldReturnEmptyList_WhenNoQuestionsExist_ForTheGivenVersion()
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync([]);

        // Act
        var result = await Sut.GetQuestionsByVersion("v1");

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeEmpty();

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestionsByVersion_WithCategoryAndSection_ShouldReturnQuestions_ForTheGivenVersionCategorySection()
    {
        // Arrange
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1", QuestionCategoryId = "Category 1", QuestionSectionId = "Section 1", VersionId = "v1" },
            new() { QuestionId = "2", QuestionText = "Question 2", QuestionCategoryId = "Category 2", QuestionSectionId = "Section 2", VersionId = "v2" },
            new() { QuestionId = "3", QuestionText = "Question 3", QuestionCategoryId = "Category 3", QuestionSectionId = "Section 3", VersionId = "v3" }
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions.Where(q => q.VersionId == "v1" && q.QuestionSectionId == "Section 1" && q.QuestionCategoryId == "Category 1"));

        // Act
        var result = await Sut.GetQuestions();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Where(q => q.VersionId == "v1" && q.QuestionSectionId == "Section 1" && q.QuestionCategoryId == "Category 1").Count());

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestionsByVersion_WithCategoryAndSection_ShouldReturnEmptyList_WhenNoQuestionsExist()
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
}