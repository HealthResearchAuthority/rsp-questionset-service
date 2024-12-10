using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Application.Specifications;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    /// <summary>
    /// Gets all questions
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions()
    {
        // specification with parameters will include all questions
        var questions = await questionRepository.GetQuestions(new QuestionSpecification());

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    /// <summary>
    /// Gets all questions for a category
    /// </summary>
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId)
    {
        // passing specification with categoryId parameter to get all questions for that category
        var questions = await questionRepository.GetQuestions(new QuestionSpecification(categoryId: categoryId));

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    /// <inheritdoc/>
    public async Task CreateQuestions(QuestionSetDto questionSet)
    {
        var adaptedCategories = questionSet.Categories.Adapt<IEnumerable<QuestionCategory>>();
        var adaptedSections = questionSet.Sections.Adapt<IEnumerable<QuestionSection>>();
        var adaptedAnswerOptions = questionSet.AnswerOptions.Adapt<IEnumerable<AnswerOption>>();
        var adaptedQuestions = questionSet.Questions.Adapt<IEnumerable<Question>>();

        await questionRepository.ClearAllEntities();
        await questionRepository.PopulateAnswerOptions(adaptedAnswerOptions);
        await questionRepository.PopulateQuestionCategories(adaptedCategories);
        await questionRepository.PopulateQuestionSections(adaptedSections);
        await questionRepository.PopulateQuestions(adaptedQuestions);
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
}