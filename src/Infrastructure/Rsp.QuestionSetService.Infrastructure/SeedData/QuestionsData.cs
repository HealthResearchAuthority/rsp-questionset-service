using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Infrastructure.SeedData;

internal static class QuestionsData
{
    public static IList<QuestionCategory> SeedCategories()
    {
        return SeedHelper.SeedData<QuestionCategory>("QuestionCategories.json");
    }

    public static IList<QuestionSection> SeedSections()
    {
        return SeedHelper.SeedData<QuestionSection>("QuestionSections.json");
    }

    public static IList<Question> SeedQuestions()
    {
        return SeedHelper.SeedData<Question>("Questions.json");
    }

    public static IList<AnswerOption> SeedAnswerOptions()
    {
        return SeedHelper.SeedData<AnswerOption>("AnswerOptions.json");
    }

    public static IList<Answer> SeedAnswers()
    {
        return SeedHelper.SeedData<Answer>("Answers.json");
    }

    public static IList<QuestionRule> SeedRules()
    {
        return SeedHelper.SeedData<QuestionRule>("QuestionRules.json");
    }

    public static IList<Domain.Entities.Version> SeedVersions()
    {
        return SeedHelper.SeedData<Domain.Entities.Version>("Versions.json");
    }
}