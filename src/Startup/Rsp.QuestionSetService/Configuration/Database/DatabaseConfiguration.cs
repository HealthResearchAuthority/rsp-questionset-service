using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Infrastructure;

namespace Rsp.QuestionSetService.Configuration.Database;

/// <summary>
/// Adds DbContext to the application
/// </summary>
public static class DatabaseConfiguration
{
    /// <summary>
    /// Adds services to the IoC container
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/></param>
    /// <param name="configuration"><see cref="IConfiguration"/></param>
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<QuestionSetDbContext>
        (
            options => options
                .UseSqlServer(configuration.GetConnectionString("QuestionSetServiceDatabaseConnection"))
        );

        return services;
    }
}