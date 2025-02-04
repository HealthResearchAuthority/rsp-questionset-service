using System.Net.Mime;
using System.Text.Json;
using Azure.Identity;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.FeatureManagement;
using Rsp.Logging.ActionFilters;
using Rsp.Logging.Extensions;
using Rsp.Logging.Interceptors;
using Rsp.Logging.Middlewares.CorrelationId;
using Rsp.Logging.Middlewares.RequestTracing;
using Rsp.QuestionSetService.Application.Constants;
using Rsp.QuestionSetService.Application.Mapping;
using Rsp.QuestionSetService.Application.Settings;
using Rsp.QuestionSetService.Configuration.Auth;
using Rsp.QuestionSetService.Configuration.Database;
using Rsp.QuestionSetService.Configuration.Dependencies;
using Rsp.QuestionSetService.Configuration.Swagger;
using Rsp.QuestionSetService.Extensions;
using Rsp.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

//Add logger
builder
    .Configuration
    .AddJsonFile("logsettings.json")
    .AddJsonFile("featuresettings.json", true, true)
    .AddEnvironmentVariables();

// this method is called by multiple projects
// serilog settings has been moved here, as all projects
// would need it
builder.AddServiceDefaults();

var services = builder.Services;
var configuration = builder.Configuration;

if (!builder.Environment.IsDevelopment())
{
    services.AddLogging(builder => builder.AddConsole());
}

if (!builder.Environment.IsDevelopment())
{
    var azureAppConfigSection = configuration.GetSection(nameof(AppSettings));
    var azureAppConfiguration = azureAppConfigSection.Get<AppSettings>();

    // Load configuration from Azure App Configuration
    builder.Configuration.AddAzureAppConfiguration(
        options =>
        {
            options.Connect
            (
                new Uri(azureAppConfiguration!.AzureAppConfiguration.Endpoint),
                new ManagedIdentityCredential(azureAppConfiguration.AzureAppConfiguration.IdentityClientID)
            )
            .Select(KeyFilter.Any)
            .Select(KeyFilter.Any, AppSettings.ServiceLabel)
            .ConfigureRefresh(refreshOptions =>
                refreshOptions
                .Register("AppSettings:Sentinel", AppSettings.ServiceLabel, refreshAll: true)
                .SetRefreshInterval(new TimeSpan(0, 0, 15))
            );
        }
    );

    services.AddAzureAppConfiguration();
}

var appSettingsSection = configuration.GetSection(nameof(AppSettings));
var appSettings = appSettingsSection.Get<AppSettings>();

// adds sql server database context
services.AddDatabase(configuration);

// Add services to the container.
services.AddServices();

services.AddHttpContextAccessor();

// routing configuration
services.AddRouting(options => options.LowercaseUrls = true);

// configures the authentication and authorization
services.AddAuthenticationAndAuthorization(appSettings!);

// Creating a feature manager without the use of DI. Injecting IFeatureManager
// via DI is appropriate in consturctor methods. At the startup, it's
// not recommended to call services.BuildServiceProvider and retreive IFeatureManager
// via provider. Instead, the follwing approach is recommended by creating FeatureManager
// with ConfigurationFeatureDefinitionProvider using the existing configuration.
var featureManager = new FeatureManager(new ConfigurationFeatureDefinitionProvider(configuration));

services
    .AddControllers(async options =>
    {
        options.Filters.Add(new ProducesAttribute(MediaTypeNames.Application.Json));
        options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status200OK));
        options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
        options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status403Forbidden));
        options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
        options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status503ServiceUnavailable));

        // add LogActionFilter if InterceptedLogging feature is enabled.
        if (await featureManager.IsEnabledAsync(Features.InterceptedLogging))
        {
            options.Filters.Add<LogActionFilter>();
        }
    })
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        options.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
    });

// add default health checks
services.Configure<HealthCheckPublisherOptions>(options => options.Period = TimeSpan.FromSeconds(300));

services.AddHealthChecks();

// adds the Swagger for the Api Documentation
services.AddSwagger();

var config = TypeAdapterConfig.GlobalSettings;

// register the mapping configuration
config.Scan(typeof(MappingRegister).Assembly);

// add LogActionFilter if InterceptedLogging feature is enabled.
if (await featureManager.IsEnabledAsync(Features.InterceptedLogging))
{
    services.AddLoggingInterceptor<LoggingInterceptor>();
}

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseAzureAppConfiguration();
}

app.UseHttpsRedirection();

app.UseCorrelationId();

app.UseRouting();

app.UseAuthentication();

app.UseRequestTracing();

app.UseAuthorization();

app.MapControllers();

// run the database migration and seed the data
await app.MigrateAndSeedDatabaseAsync();

logger.LogAsInformation("Starting Up");

await app.RunAsync();