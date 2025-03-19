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
        var result = await Sut.GetQuestions(null, null);

        // Assert
        result.ShouldBe(expectedQuestions);
        questionsService.Verify(x => x.GetQuestions(), Times.Once);
        questionsService.Verify(x => x.GetQuestions(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Theory, AutoData]
    public async Task GetQuestions_WithCategoryId_CallsGetQuestionsWithCategoryId(List<QuestionDto> expectedQuestions)
    {
        // Arrange
        const string categoryId = "category-1";
        const string sectionId = "section-1";
        expectedQuestions.ForEach(x => x.Category = categoryId);

        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetQuestions(categoryId, sectionId))
            .ReturnsAsync(expectedQuestions);

        // Act
        var result = await Sut.GetQuestions(categoryId, sectionId);

        // Assert
        result.ShouldBeOfType<List<QuestionDto>>();
        questionsService.Verify(x => x.GetQuestions(categoryId, sectionId), Times.Once);
        questionsService.Verify(x => x.GetQuestions(), Times.Never);
    }

    [Theory, AutoData]
    public async Task GetQuestions_ByVersion_CallsGetQuestionsByVersion(List<QuestionDto> expectedQuestions, string versionId)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetQuestionsByVersion(versionId))
            .ReturnsAsync(expectedQuestions);

        // Act
        var result = await Sut.GetQuestionsByVersion(versionId, null, null);

        // Assert
        result.ShouldBe(expectedQuestions);
        questionsService.Verify(x => x.GetQuestionsByVersion(versionId), Times.Once);
        questionsService.Verify(x => x.GetQuestionsByVersion(versionId, It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Theory, AutoData]
    public async Task GetQuestions_ByVersion_WithSectionAndCategory_CallsGetQuestionsByVersion(List<QuestionDto> expectedQuestions, string versionId, string sectionId, string categoryId)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetQuestionsByVersion(versionId, categoryId, sectionId))
            .ReturnsAsync(expectedQuestions);

        // Act
        var result = await Sut.GetQuestionsByVersion(versionId, categoryId, sectionId);

        // Assert
        result.ShouldBe(expectedQuestions);
        questionsService.Verify(x => x.GetQuestionsByVersion(versionId), Times.Never);
        questionsService.Verify(x => x.GetQuestionsByVersion(versionId, categoryId, sectionId), Times.Once);
    }

    [Theory, AutoData]
    public async Task AddQuestionSet_CallsAddQuestionSet(string categoryId)
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
            .Setup(x => x.AddQuestionSet(questionSet))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.AddQuestionSet(questionSet);

        // Assert
        questionsService.Verify(x => x.AddQuestionSet(questionSet), Times.Once);
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

    [Theory, AutoData]
    public async Task GetVersions_CallsGetVersions(List<VersionDto> expectedVersions)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.GetVersions())
            .ReturnsAsync(expectedVersions);

        // Act
        await Sut.GetVersions();

        // Assert
        questionsService.Verify(x => x.GetVersions(), Times.Once);
    }

    [Theory, AutoData]
    public async Task CreateDraftVersion_CallsCreateDraftVersion(VersionDto version)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.CreateDraftVersion(version))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.CreateDraftVersion(version);

        // Assert
        questionsService.Verify(x => x.CreateDraftVersion(version), Times.Once);
    }

    [Fact]
    public async Task DeleteDraftVersion_CallsDeleteDraftVersion()
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.DeleteDraftVersion())
            .Returns(Task.CompletedTask);

        // Act
        await Sut.DeleteDraftVersion();

        // Assert
        questionsService.Verify(x => x.DeleteDraftVersion(), Times.Once);
    }

    [Theory, AutoData]
    public async Task PublishVersion_CallsPublishVersion(string versionId)
    {
        // Arrange
        var questionsService = Mocker.GetMock<IQuestionService>();

        questionsService
            .Setup(x => x.PublishVersion(versionId))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.PublishVersion(versionId);

        // Assert
        questionsService.Verify(x => x.PublishVersion(versionId), Times.Once);
    }
}