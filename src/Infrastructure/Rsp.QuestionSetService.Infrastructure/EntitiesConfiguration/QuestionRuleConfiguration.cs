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
        builder.HasKey(cr => cr.RuleId);

        builder
            .HasOne<Question>()
            .WithMany()
            .HasForeignKey(qr => qr.QuestionId)
            .HasForeignKey(qr => qr.ParentQuestionId);

        builder
            .Property(p => p.Conditions)
            .HasJsonConversion();

        builder.HasData(QuestionsData.SeedRules());
    }
}