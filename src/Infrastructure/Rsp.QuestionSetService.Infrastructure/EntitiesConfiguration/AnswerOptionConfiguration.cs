using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class AnswerOptionConfiguration : IEntityTypeConfiguration<AnswerOption>
{
    public void Configure(EntityTypeBuilder<AnswerOption> builder)
    {
        builder.HasKey(ao => ao.OptionId);

        builder.HasData(QuestionsData.SeedAnswerOptions());
    }
}