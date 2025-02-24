using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Services;

public class QuestionSectionsService(IQuestionSectionsRepository questionSectionRepository) : IQuestionSectionsService
{
    /// <summary>
    ///     Gets all question sections
    /// </summary>
    public async Task<IEnumerable<QuestionSectionDto>> GetQuestionSections()
    {
        var questionSections = await questionSectionRepository.GetQuestionSections();
        return questionSections.Adapt<IEnumerable<QuestionSectionDto>>();
    }

    public async Task<QuestionSectionDto> GetPreviousQuestionSections(string currentSectionId)
    {
        var questionsSection = await questionSectionRepository.GetPreviousQuestionSection(currentSectionId);
        return questionsSection.Adapt<QuestionSectionDto>();
    }

    public async Task<QuestionSectionDto> GetNextQuestionSections(string currentSectionId)
    {
        var questionsSection = await questionSectionRepository.GetNextQuestionSection(currentSectionId);
        return questionsSection.Adapt<QuestionSectionDto>();
    }
}