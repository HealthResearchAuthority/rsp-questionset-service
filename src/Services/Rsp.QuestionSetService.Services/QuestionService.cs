using Mapster;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Application.DTOS.Responses;

namespace Rsp.QuestionSetService.Services;

public class QuestionService(IQuestionRepository questionRepository) : IQuestionService
{
    public async Task<IEnumerable<QuestionDto>> GetQuestions(string categoryId)
    {
        var questions = await questionRepository.GetQuestions(categoryId);

        return questions.Adapt<IEnumerable<QuestionDto>>();
    }

    //public async Task<IEnumerable<QuestionDto>> GetNextQuestions(string categoryId, IEnumerable<RespondentAnswer> respondentAnswers)
    //{
    //    var nextQuestions = await questionRepository.GetQuestions(categoryId);

    //    var questions = new List<Question>();

    //    foreach (var question in nextQuestions)
    //    {
    //        if (question.QuestionRules.Count == 0)
    //        {
    //            questions.Add(question);
    //            continue;
    //        }

    //        // get the question conditions
    //        var conditions = question.QuestionRules.Where(c => c.QuestionId == question.QuestionId);

    //        // check for each condition that the parent question answer
    //        // matches the option for the condition.

    //        var satisfiedConditions = 0;

    //        // get the respondent answer for question's parent question
    //        foreach (var condition in conditions)
    //        {
    //            var answer = respondentAnswers.FirstOrDefault(answer => answer.QuestionId == condition.ParentQuestionId);

    //            if (answer == null)
    //            {
    //                continue;
    //            }

    //            // answer option matches the condition option
    //            if (answer.OptionId == condition.ParentOptionId)
    //            {
    //                satisfiedConditions++;
    //            }
    //        }

    //        // all conditions are met
    //        if (satisfiedConditions == conditions.Count())
    //        {
    //            questions.Add(question);
    //        }
    //    }

    //    return questions.Adapt<IEnumerable<QuestionDto>>();
    //}
}