using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionCategoryConfiguration : IEntityTypeConfiguration<QuestionCategory>
{
    public void Configure(EntityTypeBuilder<QuestionCategory> builder)
    {
        builder.HasKey(qc => new { qc.CategoryId, qc.VersionId });

        builder
            .HasMany(qc => qc.QuestionSections)
            .WithOne()
            .HasForeignKey(q => new { q.QuestionCategoryId, q.VersionId })
            .OnDelete(DeleteBehavior.Cascade);

        builder
           .HasMany(q => q.Questions)
           .WithOne()
           .HasForeignKey(q => new { q.QuestionCategoryId, q.VersionId })
           .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(QuestionsData.SeedCategories());
    }
}