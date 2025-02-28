using Moq.AutoMock;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.WebApi.Controllers;

namespace Rsp.QuestionSetService.UnitTests.Web.Controllers;

public class QuestionCatagoriesControllerTests : TestServiceBase<QuestionCatagoriesController>
{
    [Fact]
    public async Task GetQuestionCategories_CallsGetQuestionCategories()
    {
        // Arrange
        var questionCategoriesService = Mocker.GetMock<IQuestionCategoriesService>();

        var expectedCategories = new List<CategoryDto>
        {
            new() { CategoryId = "1", CategoryName = "Math" },
            new() { CategoryId = "2", CategoryName = "Science" },
            new() { CategoryId = "3", CategoryName = "History" }
        };

        questionCategoriesService
            .Setup(x => x.GetQuestionCategories())
            .ReturnsAsync(expectedCategories);

        // Act
        var result = await Sut.GetQuestionCategories();

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeOfType<List<CategoryDto>>();
        result.ShouldBe(expectedCategories);

        questionCategoriesService.Verify(x => x.GetQuestionCategories(), Times.Once);
    }
}