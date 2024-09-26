using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;

namespace Rsp.QuestionSetService.Infrastructure;

public class QuestionSetDbContext(DbContextOptions<QuestionSetDbContext> options) : DbContext(options)
{
    public DbSet<QuestionCategory> QuestionCategories { get; set; }
    public DbSet<QuestionSection> QuestionSections { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<AnswerOption> AnswerOptions { get; set; }
    public DbSet<QuestionRule> QuestionRules { get; set; }
    public DbSet<Answer> Answers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new QuestionCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionSectionConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new AnswerOptionConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionRuleConfiguration());
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
    }
}