using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController(IQuestionService questionService) : ControllerBase
{
    /// <summary>
    /// Gets all questions and filters by category and section if provided
    /// </summary>
    [HttpGet]
    [Produces<IEnumerable<QuestionDto>>]
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string? categoryId, string? sectionId = null)
    {
        return categoryId == null ?
            await questionService.GetQuestions() :
            await questionService.GetQuestions(categoryId, sectionId);
    }

    /// <summary>
    /// Gets all questions for a given versionId and filters by category and section if provided
    /// </summary>
    /// <returns></returns>
    [HttpGet("questionset")]
    public async Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId, string? categoryId, string? sectionId = null)
    {
        return categoryId == null ?
            await questionService.GetQuestionsByVersion(versionId) :
            await questionService.GetQuestionsByVersion(versionId, categoryId, sectionId);
    }

    /// <summary>
    /// Adds a set of questions to the database (as well as corresponding categories, sections, and answer options)
    /// </summary>
    /// <param name="questionSet">A collection of categories, sections, questions, and answer options</param>
    [HttpPost("questionset")]
    public async Task AddQuestionSet(QuestionSetDto questionSet)
    {
        await questionService.CreateDraftVersion(questionSet.Version);
        await questionService.AddQuestionSet(questionSet);
    }

    /// <summary>
    /// Adds a question to the database
    /// </summary>
    /// <param name="question">The question entity to be added</param>
    [HttpPost("add")]
    public async Task AddQuestion(QuestionDto question)
    {
        await questionService.AddQuestion(question);
    }

    /// <summary>
    /// Soft deletes a question in the database
    /// </summary>
    /// <param name="questionId">The id of the question to be deleted</param>
    [HttpDelete("delete")]
    public async Task DeleteQuestion(string questionId)
    {
        await questionService.DeleteQuestion(questionId);
    }

    /// <summary>
    /// Un-deletes a soft deleted question in the database
    /// </summary>
    /// <param name="questionId">The id of the soft deleted question to be undeleted</param>
    [HttpPost("undelete")]
    public async Task UndeleteQuestion(string questionId)
    {
        await questionService.UndeleteQuestion(questionId);
    }

    /// <summary>
    /// Gets all question set versions
    /// </summary>
    [HttpGet("version/all")]
    public async Task<IEnumerable<VersionDto>> GetVersions()
    {
        return await questionService.GetVersions();
    }

    [HttpPost("version/create")]
    public async Task CreateDraftVersion(VersionDto version)
    {
        await questionService.CreateDraftVersion(version);
    }

    [HttpDelete("version/delete")]
    public async Task DeleteDraftVersion()
    {
        await questionService.DeleteDraftVersion();
    }

    [HttpPost("version/publish")]
    public async Task PublishVersion(string versionId)
    {
        await questionService.PublishVersion(versionId);
    }
}