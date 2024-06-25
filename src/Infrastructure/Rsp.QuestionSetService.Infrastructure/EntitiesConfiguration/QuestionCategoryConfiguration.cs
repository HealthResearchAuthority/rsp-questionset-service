using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class QuestionCategoryConfiguration : IEntityTypeConfiguration<QuestionCategory>
{
    public void Configure(EntityTypeBuilder<QuestionCategory> builder)
    {
        builder.HasKey(qs => qs.CategoryId);

        builder.HasData(QuestionsData.SeedCategories());
    }
}