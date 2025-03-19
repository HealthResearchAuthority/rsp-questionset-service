using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;
using Version = Rsp.QuestionSetService.Domain.Entities.Version;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    /// <summary>
    /// Gets all questions
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions()
    {
        // Only return the questions for the published version
        var publishedVersionId = await GetPublishedVersionId();

        // specification with parameters will include all questions
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(versionId: publishedVersionId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    /// <summary>
    /// Gets all questions for a category and section
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId, string? sectionId)
    {
        // Only return the questions for the published version
        var publishedVersionId = await GetPublishedVersionId();

        // passing specification with categoryId parameter to get all questions for that category
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(versionId: publishedVersionId, categoryId: categoryId, sectionId: sectionId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    public async Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId)
    {
        // specification with parameters will include all questions
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(versionId: versionId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    public async Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId, string categoryId, string? sectionId)
    {
        // passing specification with categoryId parameter to get all questions for that category
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(versionId: versionId, categoryId: categoryId, sectionId: sectionId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    /// <inheritdoc/>
    public async Task AddQuestionSet(QuestionSetDto questionSet)
    {
        var adaptedCategories = questionSet.Categories.Adapt<IEnumerable<QuestionCategory>>();
        var adaptedQuestions = questionSet.Questions.Adapt<IEnumerable<Question>>();

        await questionRepository.AddQuestionCategories(adaptedCategories);
        await questionRepository.AddQuestions(adaptedQuestions);
    }

    /// <inheritdoc/>
    public async Task AddQuestion(QuestionDto entity)
    {
        var adaptedQuestion = entity.Adapt<Question>();

        await questionRepository.AddQuestion(adaptedQuestion);
    }

    /// <inheritdoc/>
    public async Task DeleteQuestion(string questionId)
    {
        await questionRepository.DeleteQuestion(questionId);
    }

    /// <inheritdoc/>
    public async Task UndeleteQuestion(string questionId)
    {
        await questionRepository.UndeleteQuestion(questionId);
    }

    public async Task<IEnumerable<VersionDto>> GetVersions()
    {
        var versions = await questionRepository.GetVersions();

        return versions.Adapt<IEnumerable<VersionDto>>();
    }

    public async Task CreateDraftVersion(VersionDto version)
    {
        await questionRepository.DeleteDraftVersion();

        var adaptedVersion = version.Adapt<Version>();

        await questionRepository.CreateDraftVersion(adaptedVersion);
    }

    public async Task DeleteDraftVersion()
    {
        await questionRepository.DeleteDraftVersion();
    }

    public async Task PublishVersion(string versionId)
    {
        await questionRepository.PublishVersion(versionId);
    }

    private async Task<string?> GetPublishedVersionId()
    {
        var versions = await GetVersions();

        return versions.FirstOrDefault(v => v.IsPublished)?.VersionId;
    }
}