using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class VersionConfiguration : IEntityTypeConfiguration<Domain.Entities.Version>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Version> builder)
    {
        builder.HasKey(v => v.VersionId);

        // maybe remove once no longer composite key
        builder
            .HasMany<Answer>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany<AnswerOption>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany<QuestionCategory>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany<Question>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany<QuestionRule>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany<QuestionSection>()
            .WithOne()
            .HasForeignKey(a => a.VersionId)
            .HasPrincipalKey(v => v.VersionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(QuestionsData.SeedVersions());
    }
}