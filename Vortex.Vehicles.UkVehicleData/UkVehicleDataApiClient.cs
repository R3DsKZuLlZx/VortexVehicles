using System.Text.Json;
using System.Text.Json.Serialization;
using Vortex.Vehicles.UkVehicleData.Models;

namespace Vortex.Vehicles.UkVehicleData;

public class UkVehicleDataApiClient : IUkVehicleDataApiClient
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNameCaseInsensitive = true,
    };
    
    private readonly HttpClient _client;
    private readonly UkVehicleDataApiOptions _options;

    public UkVehicleDataApiClient(HttpClient client, UkVehicleDataApiOptions options)
    {
        _client = client;
        _options = options;
    }
    
    public async Task<GetVehicleDataResponse> GetVehicleData(string registration, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(registration);
        
        registration = registration.Trim();
        
        var url = $"/api/datapackage/VehicleData?v=2&api_nullitems=1&auth_apikey={_options.ApiKey}&key_VRM={registration}";

        var response = await _client.GetAsync(url, cancellationToken);
        var json = await response.Content.ReadAsStringAsync(cancellationToken);
        
        return JsonSerializer.Deserialize<GetVehicleDataResponse>(json, JsonSerializerOptions)!;
    }
}
