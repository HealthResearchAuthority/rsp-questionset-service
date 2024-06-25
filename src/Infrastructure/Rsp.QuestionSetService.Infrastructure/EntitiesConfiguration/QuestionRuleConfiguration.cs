using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionRuleConfiguration : IEntityTypeConfiguration<QuestionRule>
{
    public void Configure(EntityTypeBuilder<QuestionRule> builder)
    {
        builder.HasKey(cr => cr.RuleId);

        builder
            .HasOne<Question>()
            .WithMany()
            .HasForeignKey(qr => qr.QuestionId)
            .HasForeignKey(qr => qr.ParentQuestionId);

        var options = new JsonSerializerOptions();

        builder
            .Property(p => p.Condition)
            .HasConversion
            (
                condition => JsonSerializer.Serialize(condition, options),
                condition => JsonSerializer.Deserialize<Condition>(condition, options)!
            );

        builder.HasData(QuestionsData.SeedRules());
    }
}