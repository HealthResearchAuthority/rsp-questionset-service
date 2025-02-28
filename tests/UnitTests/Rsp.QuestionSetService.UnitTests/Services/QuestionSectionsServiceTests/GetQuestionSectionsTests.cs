using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionSectionsServiceTests;

public class GetQuestionSectionsTests : TestServiceBase<QuestionSectionsService>
{
    [Fact]
    public async Task GetQuestionSections_ShouldReturnAllSections()
    {
        // Arrange
        var sections = new List<QuestionSection>
        {
            new() { SectionId = "1", SectionName = "Section 1" },
            new() { SectionId = "2", SectionName = "Section 2" },
            new() { SectionId = "3", SectionName = "Section 3" }
        };

        Mocker
            .GetMock<IQuestionSectionsRepository>()
            .Setup(repo => repo.GetQuestionSections())
            .ReturnsAsync(sections);

        // Act
        var result = await Sut.GetQuestionSections();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(sections.Count);
    }
}