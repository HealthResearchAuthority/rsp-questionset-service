using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.WebApi.Controllers;

namespace Rsp.QuestionSetService.UnitTests.Web.Controllers;

public class QuestionsControllerTests : TestServiceBase<QuestionsController>
{
    [Theory, AutoData]
    public async Task GetQuestions_NoCategoryId_CallsGetQuestions(List<QuestionDto> expectedQuestions)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetQuestions())
            .ReturnsAsync(expectedQuestions);

        // Act
        var result = await Sut.GetQuestions(null);

        // Assert
        result.ShouldBe(expectedQuestions);
        questionsService.Verify(x => x.GetQuestions(), Times.Once);
        questionsService.Verify(x => x.GetQuestions(It.IsAny<string>()), Times.Never);
    }

    [Theory, AutoData]
    public async Task GetQuestions_WithCategoryId_CallsGetQuestionsWithCategoryId(List<QuestionDto> expectedQuestions)
    {
        // Arrange
        const string categoryId = "category-1";
        expectedQuestions.ForEach(x => x.Category = categoryId);

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetQuestions(categoryId))
            .ReturnsAsync(expectedQuestions);

        // Act
        var result = await Sut.GetQuestions(categoryId);

        // Assert
        result.ShouldBeOfType<List<QuestionDto>>();
        questionsService.Verify(x => x.GetQuestions(categoryId), Times.Once);
        questionsService.Verify(x => x.GetQuestions(), Times.Never);
    }

    [Theory, AutoData]
    public async Task CreateQuestions_CallsCreateQuestions(string categoryId)
    {
        // Arrange
        var questionSet = new QuestionSetDto
        {
            Categories =
            [
                new CategoryDto { CategoryId = categoryId, CategoryName = "Category 1" }
            ]
        };

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.CreateQuestions(questionSet))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.CreateQuestions(questionSet);

        // Assert
        questionsService.Verify(x => x.CreateQuestions(questionSet), Times.Once);
    }

    [Fact]
    public async Task AddQuestion_CallsAddQuestion()
    {
        // Arrange
        var question = new QuestionDto { QuestionId = "1", QuestionText = "Question 1" };

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.AddQuestion(question))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.AddQuestion(question);

        // Assert
        questionsService.Verify(x => x.AddQuestion(question), Times.Once);
    }

    [Fact]
    public async Task DeleteQuestion_CallsDeleteQuestion()
    {
        // Arrange
        const string questionId = "question-1";

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.DeleteQuestion(questionId))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.DeleteQuestion(questionId);

        // Assert
        questionsService.Verify(x => x.DeleteQuestion(questionId), Times.Once);
    }

    [Fact]
    public async Task UndeleteQuestion_CallsUndeleteQuestion()
    {
        // Arrange
        const string questionId = "question-1";

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.UndeleteQuestion(questionId))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.UndeleteQuestion(questionId);

        // Assert
        questionsService.Verify(x => x.UndeleteQuestion(questionId), Times.Once);
    }
}