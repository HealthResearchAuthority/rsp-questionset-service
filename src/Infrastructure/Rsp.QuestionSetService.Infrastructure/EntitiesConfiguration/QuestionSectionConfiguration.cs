using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionSectionConfiguration : IEntityTypeConfiguration<QuestionSection>
{
    public void Configure(EntityTypeBuilder<QuestionSection> builder)
    {
        builder.HasKey(qs => new { qs.SectionId, qs.VersionId });

        builder
           .HasMany(qs => qs.Questions)
           .WithOne(q => q.QuestionSection)
           .HasForeignKey(q => new { q.QuestionSectionId, q.VersionId })
           .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(QuestionsData.SeedSections());
    }
}