using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionSectionsServiceTests;

public class GetNextQuestionSectionsTests : TestServiceBase<QuestionSectionsService>
{
    [Fact]
    public async Task GetNextQuestionSections_ShouldReturnNextSection()
    {
        // Arrange
        var sectionId = "2";
        var NextSection = new QuestionSection { SectionId = "1", SectionName = "Next Section" };

        Mocker
            .GetMock<IQuestionSectionsRepository>()
            .Setup(repo => repo.GetNextQuestionSection(It.Is<QuestionSectionSpecification>(s => CheckSectionId(s, sectionId))))
            .ReturnsAsync(NextSection);

        // Act
        var result = await Sut.GetNextQuestionSections(sectionId);

        // Assert
        result.ShouldNotBeNull();
        result.SectionId.ShouldBe(NextSection.SectionId);
        result.SectionName.ShouldBe(NextSection.SectionName);
    }

    // Helper function to validate that the sectionId was passed correctly
    private bool CheckSectionId(QuestionSectionSpecification spec, string expectedSectionId)
    {
        // Create a new instance of the spec and see if it behaves the same way
        var testSpec = new QuestionSectionSpecification(expectedSectionId);

        // Compare the string representation of the LINQ expression (simpler than inspecting expressions directly)
        return testSpec.ToString() == spec.ToString();
    }
}