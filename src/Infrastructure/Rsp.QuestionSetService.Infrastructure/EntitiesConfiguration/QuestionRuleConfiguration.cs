using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.Extensions;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionRuleConfiguration : IEntityTypeConfiguration<QuestionRule>
{
    public void Configure(EntityTypeBuilder<QuestionRule> builder)
    {
        builder.HasKey(qr => new { qr.RuleId, qr.VersionId });

        builder
            .HasOne<Question>()
            .WithMany()
            .HasForeignKey(qr => new { qr.ParentQuestionId, qr.VersionId });

        builder
            .Property(p => p.Conditions)
            .HasJsonConversion();

        builder.HasData(QuestionsData.SeedRules());
    }
}