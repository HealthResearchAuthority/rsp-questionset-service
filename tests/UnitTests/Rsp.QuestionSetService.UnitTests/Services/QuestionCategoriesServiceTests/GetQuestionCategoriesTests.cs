using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionCategoriesServiceTests;

public class GetQuestionCategoriesTests : TestServiceBase<QuestionCategoriesService>
{
    [Fact]
    public async Task GetQuestions_ShouldReturnAllQuestions()
    {
        // Arrange
        var questions = new List<QuestionCategory>
        {
            new() { CategoryId = "1", CategoryName = "Question 1" },
            new() { CategoryId = "2", CategoryName = "Question 2" },
            new() { CategoryId = "3", CategoryName = "Question 3" }
        };

        Mocker
            .GetMock<IQuestionCategoriesRepository>()
            .Setup(repo => repo.GetQuestionCategories(It.IsAny<QuestionCategorySpecification>()))
            .ReturnsAsync(questions);

        // Act
        var result = await Sut.GetQuestionCategories();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(questions.Count);
    }
}