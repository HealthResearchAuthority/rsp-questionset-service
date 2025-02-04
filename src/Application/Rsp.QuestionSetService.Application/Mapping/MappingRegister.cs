using Mapster;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Mapping;

/// <summary>
/// Register for type mappings
/// </summary>
public class MappingRegister : IRegister
{
    /// <summary>
    /// Register method to configure the mappings
    /// </summary>
    public void Register(TypeAdapterConfig config)
    {
        // register your mapster mappings here only if you
        // need custom mapping or need different settings for mapping

        config
            .NewConfig<Answer, AnswerDto>()
            .Map(dest => dest.AnswerId, source => source.AnswerOptionId)
            .Map(dest => dest.AnswerText, source => source.AnswerOption.OptionText);

        config
            .NewConfig<AnswerDto, Answer>()
            .Ignore(dest => dest.AnswerId)
            .Map(dest => dest.AnswerOptionId, source => source.AnswerId)
            .Map(dest => dest.AnswerOption.OptionText, source => source.AnswerText)
            .Map(dest => dest.AnswerOption.OptionId, source => source.AnswerId);

        config
            .NewConfig<Condition, ConditionDto>()
            .TwoWays();

        config
            .NewConfig<QuestionRule, RuleDto>()
            .TwoWays();

        config
            .NewConfig<QuestionCategory, CategoryDto>()
            .TwoWays();

        config
            .NewConfig<QuestionSection, SectionDto>()
            .TwoWays();

        config
            .NewConfig<AnswerOption, AnswerOptionDto>()
            .TwoWays();

        // QuestionDto to Question mapping
        config
            .NewConfig<QuestionDto, Question>()
            .MapToConstructor(true)
            .Map(dest => dest.QuestionCategoryId, source => source.Category)
            .Map(dest => dest.QuestionSectionId, source => source.SectionId)
            .Map(dest => dest.QuestionSection.SectionId, source => source.SectionId)
            .Map(dest => dest.QuestionSection.QuestionCategoryId, source => source.Category)
            .Map(dest => dest.QuestionSection.SectionName, source => source.Section)
            .Map(dest => dest.Conformance, source => GetConformance(source))
            .Map(dest => dest.QuestionRules, source => source.Rules);

        // Question to GetQuestionsResponse mappings
        config
            .NewConfig<Question, QuestionDto>()
            .MapToConstructor(true)
            .Map(dest => dest.Category, source => source.QuestionCategoryId)
            .Map(dest => dest.SectionId, source => source.QuestionSection.SectionId)
            .Map(dest => dest.Section, source => source.QuestionSection.SectionName)
            .Map(dest => dest.IsMandatory, _ => true, source => source.Conformance == "Mandatory")
            .Map(dest => dest.IsOptional, _ => true, source => source.Conformance == "Optional")
            .Map(dest => dest.Rules, source => source.QuestionRules);
    }

    private static string GetConformance(QuestionDto source)
    {
        return source switch
        {
            { IsMandatory: true } => "Mandatory",
            { IsOptional: true } => "Optional",
            _ => "Conditional"
        };
    }
}