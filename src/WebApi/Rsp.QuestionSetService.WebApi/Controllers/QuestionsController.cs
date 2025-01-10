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

    [HttpGet("questionset")]
    public async Task<IEnumerable<QuestionDto>> GetQuestionsByVersion(string versionId, string? categoryId)
    {
        return categoryId == null ?
            await questionService.GetQuestionsByVersion(versionId) :
            await questionService.GetQuestionsByVersion(versionId, categoryId);
    }

    /// <summary>
    /// Deletes a draft question set (if one exists) and adds a draft question set to the database
    /// </summary>
    /// <param name="questionSet">A collection of categories, sections, questions, and answer options</param>
    [HttpPost("questionset")]
    public async Task AddQuestionSet(QuestionSetDto questionSet)
    {
        await questionService.CreateDraftVersion(questionSet.Version);
        await questionService.AddQuestionSet(questionSet);
    }

    [HttpPost("questionset/addMock")]
    public async Task AddMockQuestionSet()
    {
        var mockQuestionSet = new QuestionSetDto()
        {
            Version = new VersionDto()
            {
                VersionId = "vMock",
                CreatedAt = DateTime.UtcNow,
                IsDraft = true
            },
            Categories =
            [
                new CategoryDto()
                {
                    CategoryId = "A",
                    CategoryName = "Mock Category A",
                    VersionId = "vMock"
                },
            ],
            Questions = [
                new QuestionDto()
                {
                    QuestionId = "IQA0001",
                    Category = "A",
                    SectionId = "IQT0001",
                    Section = "Mock Section 1",
                    Sequence = 1,
                    Heading = "1",
                    QuestionText = "Mock Question 1",
                    QuestionType = "Look-up list",
                    DataType = "Checkbox",
                    IsMandatory = true,
                    IsOptional = false,
                    Answers = [
                        new AnswerDto()
                        {
                            AnswerId = "OPT0001",
                            AnswerText = "Mock Answer 1",
                            VersionId = "vMock"
                        },
                        new AnswerDto()
                        {
                            AnswerId = "OPT0002",
                            AnswerText = "Mock Answer 2",
                            VersionId = "vMock"
                        },
                    ],
                    Rules = [],
                    VersionId = "vMock"
                },
                new QuestionDto()
                {
                    QuestionId = "IQA0002",
                    Category = "A",
                    SectionId = "IQT0001",
                    Section = "Mock Section 1",
                    Sequence = 2,
                    Heading = "2",
                    QuestionText = "Mock Question 2",
                    QuestionType = "Boolean",
                    DataType = "Boolean",
                    IsMandatory = true,
                    IsOptional = false,
                    Answers = [
                        new AnswerDto()
                        {
                            AnswerId = "OPT0001",
                            AnswerText = "Mock Answer 1",
                            VersionId = "vMock"
                        },
                        new AnswerDto()
                        {
                            AnswerId = "OPT0002",
                            AnswerText = "Mock Answer 2",
                            VersionId = "vMock"
                        },
                    ],
                    Rules = [],
                    VersionId = "vMock"
                },
                new QuestionDto()
                {
                    QuestionId = "IQA0003",
                    Category = "A",
                    SectionId = "IQT0001",
                    Section = "Mock Section 1",
                    Sequence = 3,
                    Heading = "3",
                    QuestionText = "Mock Question 3",
                    QuestionType = "Text",
                    DataType = "Text",
                    IsMandatory = true,
                    IsOptional = false,
                    Answers = [],
                    Rules = [
                        new RuleDto() {
                            Sequence = 1,
                            Mode = "AND",
                            QuestionId = "IQA0003",
                            ParentQuestionId = null,
                            Description = "Length between 15 and 100 characters",
                            Conditions = [
                                new ConditionDto() {
                                    Mode = "AND",
                                    Operator = "LENGTH",
                                    Value = "15,100",
                                    Negate = false,
                                    ParentOptions = [],
                                    OptionType = "",
                                    Description = "Length between 15 and 100 characters",
                                }
                            ],
                            VersionId = "vMock",
                        },
                    ],
                    VersionId = "vMock"
                },
                new QuestionDto()
                {
                    QuestionId = "IQA0004",
                    Category = "A",
                    SectionId = "IQT0002",
                    Section = "Mock Section 2",
                    Sequence = 1,
                    Heading = "1",
                    QuestionText = "Mock Question 4",
                    QuestionType = "Text",
                    DataType = "Text",
                    IsMandatory = false,
                    IsOptional = false,
                    Answers = [],
                    Rules = [
                        new RuleDto() {
                            Sequence = 1,
                            Mode = "AND",
                            QuestionId = "IQA0004",
                            ParentQuestionId = "IQA0002",
                            Description = "Must select 'Mock Answer 1' for Question IQA0002",
                            Conditions = [
                                new ConditionDto() {
                                    Mode = "AND",
                                    Operator = "IN",
                                    Value = null,
                                    Negate = false,
                                    ParentOptions = ["OPT0001"],
                                    OptionType = "Single",
                                    Description = "Select an option",
                                }
                            ],
                            VersionId = "vMock",
                        },
                    ],
                    VersionId = "vMock"
                },
            ]
        };

        await questionService.CreateDraftVersion(mockQuestionSet.Version);
        await questionService.AddQuestionSet(mockQuestionSet);
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