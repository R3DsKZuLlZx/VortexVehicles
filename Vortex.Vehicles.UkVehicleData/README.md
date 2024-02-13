# Vortex UkVehicleData Integration

[![Nuget](https://img.shields.io/nuget/v/Vortex.Vehicles.UkVehicleData?label=NuGet)](https://www.nuget.org/packages/Vortex.Vehicles.UkVehicleData)
[![Nuget](https://img.shields.io/nuget/dt/Vortex.Vehicles.UkVehicleData?label=Downloads)](https://www.nuget.org/packages/Vortex.Vehicles.UkVehicleData)

The goal of this package is to expose the UkVehicleData API as a simple to use package.

If you find this project useful, please give it a star. Thanks! ⭐

## Getting Started

The easiest way to get started is to install the [package](https://www.nuget.org/packages/Vortex.Vehicles.UkVehicleData):
```
dotnet add package Vortex.Vehicles.UkVehicleData
```

Adding the UkVehicleData client using an API key:
```csharp
services.AddUkVehicleData("YourApiKey");
```

Adding the UkVehicleData client using `IConfiguration`:
```csharp
services.AddUkVehicleData(configuration, "YourSectionName");
```

App settings:
```json
{
  "YourSectionName": {
    "ApiKey": "YourApiKey",
    "BaseAddress": "UkVehicleDataBaseAddress"
  }
}
```

Once the client is configured, you can inject the `IUkVehicleDataApiClient` into your class through the constructor.
```csharp
public class ExampleClass
{
    private readonly IUkVehicleDataApiClient _client;
    
    public ExampleClass(IUkVehicleDataApiClient client)
    {
        _client = client;
    }

    public async Task ExampleMethod(string registration)
    {
        var response = await _client.GetVehicleData(registration, CancellationToken.None);
    }   
}
```

## Technologies

* [ASP.NET Core 8](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [UkVehicleData](https://ukvehicledata.co.uk/dvla-data-api)

## Support

If you are having problems, please let me know by raising a new issue.

## License

Feel free to do what you want.
