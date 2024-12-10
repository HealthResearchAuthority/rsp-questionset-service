using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.QuestionId);

        builder.HasQueryFilter(q => !q.IsDeleted);

        builder
            .HasIndex(q => q.IsDeleted)
            .HasFilter("IsDeleted = 0");

        builder
            .HasMany(q => q.Answers)
            .WithOne()
            .HasForeignKey(ans => ans.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(q => q.QuestionRules)
            .WithOne()
            .HasForeignKey(qr => qr.QuestionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(q => q.QuestionRules)
            .WithOne()
            .HasForeignKey(qr => qr.ParentQuestionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(QuestionsData.SeedQuestions());
    }
}