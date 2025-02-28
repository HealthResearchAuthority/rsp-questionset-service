using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.UnitTests.Services.QuestionSectionsServiceTests;

public class GetPreviousQuestionSectionsTests : TestServiceBase<QuestionSectionsService>
{
    [Fact]
    public async Task GetPreviousQuestionSections_ShouldReturnPreviousSection()
    {
        // Arrange
        var sectionId = "2";
        var previousSection = new QuestionSection { SectionId = "1", SectionName = "Previous Section" };

        Mocker
            .GetMock<IQuestionSectionsRepository>()
            .Setup(repo =>
                repo.GetPreviousQuestionSection(It.Is<QuestionSectionSpecification>(s => CheckSectionId(s, sectionId))))
            .ReturnsAsync(previousSection);

        // Act
        var result = await Sut.GetPreviousQuestionSections(sectionId);

        // Assert
        result.ShouldNotBeNull();
        result.SectionId.ShouldBe(previousSection.SectionId);
        result.SectionName.ShouldBe(previousSection.SectionName);
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