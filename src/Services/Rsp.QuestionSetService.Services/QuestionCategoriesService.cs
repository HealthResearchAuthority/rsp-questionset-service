using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Services;

public class QuestionCategoriesService(IQuestionCategoriesRepository questionCategoriesRepository) : IQuestionCategoriesService
{
    /// <summary>
    ///     Gets all question categories
    /// </summary>
    public async Task<IEnumerable<CategoryDto>> GetQuestionCategories()
    {
        var questionSections = await questionCategoriesRepository.GetQuestionCategories();
        return questionSections.Adapt<IEnumerable<CategoryDto>>();
    }
}