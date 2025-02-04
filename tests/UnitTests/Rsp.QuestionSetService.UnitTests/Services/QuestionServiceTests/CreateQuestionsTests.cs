using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionServiceTests;

public class CreateQuestionsTests : TestServiceBase<QuestionService>
{
    [Theory, AutoData]
    public async Task CreateQuestions_ShouldClearAndPopulateEntities(QuestionSetDto questionSet)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.ClearAllEntities())
            .Returns(Task.CompletedTask);

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PopulateAnswerOptions(It.IsAny<IEnumerable<AnswerOption>>()))
            .Returns(Task.CompletedTask);

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PopulateQuestionCategories(It.IsAny<IEnumerable<QuestionCategory>>()))
            .Returns(Task.CompletedTask);

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PopulateQuestionSections(It.IsAny<IEnumerable<QuestionSection>>()))
            .Returns(Task.CompletedTask);

        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.PopulateQuestions(It.IsAny<IEnumerable<Question>>()))
            .Returns(Task.CompletedTask);

        // Act
        await Sut.CreateQuestions(questionSet);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.ClearAllEntities(), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateAnswerOptions(It.IsAny<IEnumerable<AnswerOption>>()), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestionCategories(It.IsAny<IEnumerable<QuestionCategory>>()), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestionSections(It.IsAny<IEnumerable<QuestionSection>>()), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestions(It.IsAny<IEnumerable<Question>>()), Times.Once);
    }

    [Theory, AutoData]
    public async Task CreateQuestions_ShouldHandleEmptyQuestionSet(QuestionSetDto emptyQuestionSet)
    {
        // Arrange
        emptyQuestionSet.Categories = [];
        emptyQuestionSet.Sections = [];
        emptyQuestionSet.AnswerOptions = [];
        emptyQuestionSet.Questions = [];

        // Act
        await Sut.CreateQuestions(emptyQuestionSet);

        // Assert
        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.ClearAllEntities(), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateAnswerOptions(It.Is<IEnumerable<AnswerOption>>(ao => !ao.Any())), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestionCategories(It.Is<IEnumerable<QuestionCategory>>(qc => !qc.Any())), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestionSections(It.Is<IEnumerable<QuestionSection>>(qs => !qs.Any())), Times.Once);

        Mocker
            .GetMock<IQuestionRepository>()
            .Verify(repo => repo.PopulateQuestions(It.Is<IEnumerable<Question>>(q => !q.Any())), Times.Once);
    }

    [Theory, AutoData]
    public async Task CreateQuestions_ShouldHandleExceptions(QuestionSetDto questionSet)
    {
        // Arrange
        Mocker
            .GetMock<IQuestionRepository>()
            .Setup(repo => repo.ClearAllEntities())
            .ThrowsAsync(new Exception("Test exception"));

        // Act & Assert
        await Should.ThrowAsync<Exception>(async () => await Sut.CreateQuestions(questionSet));
    }
}