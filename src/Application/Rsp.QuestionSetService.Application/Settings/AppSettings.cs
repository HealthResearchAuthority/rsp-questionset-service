namespace Rsp.QuestionSetService.Application.Settings;

public class AppSettings
{
    /// <summary>
    /// Gets or sets authentication settings
    /// </summary>
    public AuthSettings AuthSettings { get; set; } = null!;

    /// <summary>
    /// Settings for Azure AppConfiguration
    /// </summary>
    public AzureAppConfigurations AzureAppConfiguration { get; set; } = null!;
}