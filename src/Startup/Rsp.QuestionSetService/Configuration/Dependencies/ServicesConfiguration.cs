using Rsp.QuestionSetService.Application;
using Rsp.QuestionSetService.Application.Authentication.Helpers;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Application.Contracts.Services;
using Rsp.QuestionSetService.Infrastructure.Repositories;
using Rsp.QuestionSetService.Services;

namespace Rsp.QuestionSetService.Configuration.Dependencies;

/// <summary>
///  User Defined Services Configuration
/// </summary>
public static class ServicesConfiguration
{
    /// <summary>
    /// Adds services to the IoC container
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/></param>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // example of configuring the IoC container to inject the dependencies

        services.AddSingleton<ITokenHelper, TokenHelper>();

        services.AddTransient<IQuestionService, QuestionService>();

        services.AddTransient<IQuestionRepository, QuestionRepository>();
        services.AddMediatR(option => option.RegisterServicesFromAssemblyContaining<IApplication>());

        return services;
    }
}