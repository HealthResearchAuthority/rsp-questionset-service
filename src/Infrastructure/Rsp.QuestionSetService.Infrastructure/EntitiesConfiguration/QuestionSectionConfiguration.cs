using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionSectionConfiguration : IEntityTypeConfiguration<QuestionSection>
{
    public void Configure(EntityTypeBuilder<QuestionSection> builder)
    {
        builder.HasKey(qs => qs.SectionId);

        builder
           .HasMany(qs => qs.Questions)
           .WithOne(q => q.QuestionSection)
           .HasForeignKey(q => q.QuestionSectionId)
           .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(QuestionsData.SeedSections());
    }
}