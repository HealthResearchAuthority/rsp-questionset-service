using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder
            .HasKey(a => new { a.AnswerId, a.VersionId });

        builder
            .HasOne(a => a.AnswerOption)
            .WithMany()
            .HasForeignKey(a => new { a.AnswerOptionId, a.VersionId });

        // because of the foreign key, the unique index is automatically created
        // same AnswerOptionId will be used for the same version but for
        // a different answer, so it is not unique
        builder
            .HasIndex(a => new { a.AnswerOptionId, a.VersionId })
            .IsUnique(false);

        builder.HasData(QuestionsData.SeedAnswers());
    }
}