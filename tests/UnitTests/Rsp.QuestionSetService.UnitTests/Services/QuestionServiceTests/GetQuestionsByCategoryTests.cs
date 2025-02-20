using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class GetQuestionsByCategoryTests : TestServiceBase<QuestionService>
{
    [Fact]
    public async Task GetQuestions_CategoryId_ShouldReturnQuestionsForCategory()
    {
        // Arrange
        const string categoryId = "category1";
        const string sectionId = "section1";
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1", QuestionCategoryId = categoryId },
            new() { QuestionId = "2", QuestionText = "Question 2", QuestionCategoryId = categoryId },
            new() { QuestionId = "3", QuestionText = "Question 3", QuestionCategoryId = categoryId }
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions);

        // Act
        var result = await Sut.GetQuestions(categoryId,sectionId);

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Count);
        result.ShouldAllBe(dto => dto.Category == categoryId);

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestions_WithQuestionCategoryId_ShouldReturnEmptyList_WhenNoQuestionsExistForCategory()
    {
        // Arrange
        const string categoryId = "nonexistentCategory";
        const string sectionId = "section1";
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync([]);

        // Act
        var result = await Sut.GetQuestions(categoryId, sectionId);

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeEmpty();

        // Verify
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()), Times.Once);
    }

    [Fact]
    public async Task GetQuestions_WithQuestionCategoryId_ShouldMapQuestionsToQuestionDtos()
    {
        // Arrange
        const string categoryId = "category1";
        const string sectionId = "section1";
        var questions = new List<Question>()
        {
            new() { QuestionId = "1", QuestionText = "Question 1", QuestionCategoryId = categoryId, QuestionSectionId = sectionId},
            new() { QuestionId = "2", QuestionText = "Question 2", QuestionCategoryId = categoryId, QuestionSectionId = sectionId },
            new() { QuestionId = "3", QuestionText = "Question 3", QuestionCategoryId = categoryId , QuestionSectionId = sectionId}
        };

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.GetQuestions(It.IsAny<QuestionSpecification>()))
            .ReturnsAsync(questions);

        // Act
        var result = await Sut.GetQuestions(categoryId, sectionId);

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Count);
        result.ShouldAllBe(dto =>
            dto.QuestionId != null &&
            dto.QuestionText != null &&
            dto.Category == categoryId
        );
    }
}