using Mapster;
using Rsp.QuestionSetService.Application.DTOS.Responses;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Configuration.Mapping;

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
            .NewConfig<Condition, ConditionDto>();

        config
            .NewConfig<QuestionRule, RuleDto>();

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

        // QuestionDto to Question mapping
    }
}