using System.ComponentModel.DataAnnotations;

namespace Vortex.Vehicles.UkVehicleData;

public class UkVehicleDataApiOptions
{
    public UkVehicleDataApiOptions(string apiKey)
    {
        ApiKey = apiKey;
    }
    
    public UkVehicleDataApiOptions(string apiKey, string baseAddress)
    {
        ApiKey = apiKey;
        BaseAddress = new Uri(baseAddress);
    }
    
    public UkVehicleDataApiOptions(string apiKey, Uri baseAddress)
    {
        ApiKey = apiKey;
        BaseAddress = baseAddress;
    }
    
    /// <summary>
    /// Gets the base address used for the UkVehicleData API.
    /// </summary>
    public Uri BaseAddress { get; } = new("https://uk1.ukvehicledata.co.uk");

    /// <summary>
    /// Gets the API key used for the UkVehicleData API.
    /// </summary>
    [Required]
    public string ApiKey { get; }
}
