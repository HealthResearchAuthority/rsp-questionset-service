using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Domain.Entities;
using Rsp.QuestionSetService.Infrastructure.EntitiesConfiguration;
using Rsp.QuestionSetService.Infrastructure.Interceptors;

namespace Rsp.QuestionSetService.Infrastructure;

/// <summary>
/// Questionset Database context
/// </summary>
public class QuestionSetDbContext(DbContextOptions<QuestionSetDbContext> options) : DbContext(options)
{
    public DbSet<QuestionCategory> QuestionCategories { get; set; }
    public DbSet<QuestionSection> QuestionSections { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<AnswerOption> AnswerOptions { get; set; }
    public DbSet<QuestionRule> QuestionRules { get; set; }
    public DbSet<Answer> Answers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.AddInterceptors(new SoftDeleteInterceptor());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Question>()
            .HasQueryFilter(q => !q.IsDeleted);

        modelBuilder.ApplyConfiguration(new QuestionCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionSectionConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new AnswerOptionConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionRuleConfiguration());
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
    }
}