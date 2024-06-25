using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Infrastructure;

namespace Rsp.QuestionSetService.Extensions;

/// <summary>
/// Define an extension method on WebApplication to support migrating and seeding the database
/// </summary>
[ExcludeFromCodeCoverage]
public static class WebApplicationExtensions
{
    /// <summary>
    /// Migrates and seed the database.
    /// </summary>
    /// <param name="app">The WebApplication instance</param>
    public static async Task MigrateAndSeedDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        await using var context = scope.ServiceProvider.GetRequiredService<QuestionSetDbContext>();

        await context.Database.MigrateAsync();
    }
}