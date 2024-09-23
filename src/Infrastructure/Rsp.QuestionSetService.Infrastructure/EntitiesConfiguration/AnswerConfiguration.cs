using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.SeedData;

namespace Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(qo => qo.AnswerId);

        builder.HasData(QuestionsData.SeedAnswers());
    }
}