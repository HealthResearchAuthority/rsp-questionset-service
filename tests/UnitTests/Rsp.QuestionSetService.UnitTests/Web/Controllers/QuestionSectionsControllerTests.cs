using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.WebApi.Controllers;

namespace Rsp.QuestionSetService.UnitTests.Web.Controllers;

public class QuestionSectionsControllerTests : TestServiceBase<QuestionSectionsController>
{
    [Fact]
    public async Task GetQuestionSections_CallsGetQuestionSections()
    {
        // Arrange
        var questionSectionsService = Mocker.GetMock<IQuestionSectionsService>();

        var expectedSections = new List<QuestionSectionDto>
        {
            new() { QuestionCategoryId = "1", SectionName = "Algebra" },
            new() { QuestionCategoryId = "2", SectionName = "Physics" },
            new() { QuestionCategoryId = "3", SectionName = "World History" }
        };

        questionSectionsService
            .Setup(x => x.GetQuestionSections())
            .ReturnsAsync(expectedSections);

        // Act
        var result = await Sut.GetQuestionSections();

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeOfType<List<QuestionSectionDto>>();
        result.ShouldBe(expectedSections);
        questionSectionsService.Verify(x => x.GetQuestionSections(), Times.Once);
    }

    [Fact]
    public async Task GetPreviousQuestionSection_ReturnsExpectedResult()
    {
        // Arrange
        var sectionId = "123";
        var expectedDto = new QuestionSectionDto { SectionId = "prev-section" };

        Mocker.GetMock<IQuestionSectionsService>()
            .Setup(s => s.GetPreviousQuestionSections(sectionId))
            .ReturnsAsync(expectedDto);

        // Act
        var result = await Sut.GetPreviousQuestionSection(sectionId);

        // Assert
        var actionResult = Assert.IsType<ActionResult<QuestionSectionDto>>(result);
        var okResult = Assert.IsType<QuestionSectionDto>(actionResult.Value);
        Assert.Equal(expectedDto.SectionId, okResult.SectionId);

        Mocker.GetMock<IQuestionSectionsService>().Verify(s => s.GetPreviousQuestionSections(sectionId), Times.Once);
    }

    [Fact]
    public async Task GetNextQuestionSection_ReturnsExpectedResult()
    {
        // Arrange
        var sectionId = "123";
        var expectedDto = new QuestionSectionDto { SectionId = "next-section" };

        Mocker.GetMock<IQuestionSectionsService>()
            .Setup(s => s.GetNextQuestionSections(sectionId))
            .ReturnsAsync(expectedDto);

        // Act
        var result = await Sut.GetNextQuestionSection(sectionId);

        // Assert
        var actionResult = Assert.IsType<ActionResult<QuestionSectionDto>>(result);
        var okResult = Assert.IsType<QuestionSectionDto>(actionResult.Value);
        Assert.Equal(expectedDto.SectionId, okResult.SectionId);

        Mocker.GetMock<IQuestionSectionsService>().Verify(s => s.GetNextQuestionSections(sectionId), Times.Once);
    }
}
