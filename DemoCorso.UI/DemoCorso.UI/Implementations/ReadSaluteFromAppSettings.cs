using DemoCorso.Core.Interfaces;

namespace DemoCorso.UI.Implementations;

public class ReadSaluteFromAppSettings : ISalute
{
    private readonly IConfiguration configuration;

    public ReadSaluteFromAppSettings(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public string GetSalute()
    {
        return configuration["Saluto"]!;
    }
}
