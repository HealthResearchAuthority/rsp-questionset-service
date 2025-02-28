using Microsoft.AspNetCore.Mvc;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController(IQuestionService questionService) : ControllerBase
{
    /// <summary>
    /// Gets all questions or filters by category and section if provided
    /// </summary>
    [HttpGet]
    [Produces<IEnumerable<QuestionDto>>]
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string? categoryId, string? sectionId= null)
    {
        return categoryId == null  ?
            await questionService.GetQuestions() :
            await questionService.GetQuestions(categoryId, sectionId);
    }

    /// <summary>
    /// Clears the database and recreates based on provided question set
    /// </summary>
    /// <param name="questionSet">A collection of categories, sections, questions, and answer options</param>
    [HttpPost]
    public async Task CreateQuestions(QuestionSetDto questionSet)
    {
        await questionService.CreateQuestions(questionSet);
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
}