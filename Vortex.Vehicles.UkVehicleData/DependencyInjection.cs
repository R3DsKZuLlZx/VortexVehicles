using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Vortex.Vehicles.UkVehicleData;

public static class DependencyInjection
{
    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        string apiKey)
        => serviceCollection.AddUkVehicleData(apiKey, httpBuilder: null);

    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        string apiKey,
        Action<IHttpClientBuilder>? httpBuilder)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        
        return serviceCollection
            .AddSingleton(Options.Create(new UkVehicleDataApiOptions(apiKey)))
            .AddUkVehicleDataClients(httpBuilder);
    }
    
    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        UkVehicleDataApiOptions options)
        => serviceCollection.AddUkVehicleData(options, httpBuilder: null);

    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        UkVehicleDataApiOptions options,
        Action<IHttpClientBuilder>? httpBuilder)
        => serviceCollection
            .AddSingleton(Options.Create(options))
            .AddUkVehicleDataClients(httpBuilder);

    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        IConfiguration configuration,
        string sectionName = nameof(UkVehicleDataApiOptions))
        => serviceCollection.AddUkVehicleData(configuration, httpBuilder: null, sectionName);

    public static IServiceCollection AddUkVehicleData(
        this IServiceCollection serviceCollection,
        IConfiguration configuration,
        Action<IHttpClientBuilder>? httpBuilder,
        string sectionName = nameof(UkVehicleDataApiOptions))
        => serviceCollection
            .AddOptions<UkVehicleDataApiOptions>()
            .Bind(configuration.GetSection(sectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart()
            .Services
            .AddUkVehicleDataClients(httpBuilder);

    private static IServiceCollection AddUkVehicleDataClients(
        this IServiceCollection serviceCollection,
        Action<IHttpClientBuilder>? httpBuilderCallback)
    {
        var httpBuilder = serviceCollection
            .AddSingleton(s => s.GetRequiredService<IOptions<UkVehicleDataApiOptions>>().Value)
            .AddHttpClient<IUkVehicleDataApiClient, UkVehicleDataApiClient>((services, client) =>
            {
                var options = services.GetRequiredService<IOptions<UkVehicleDataApiOptions>>().Value;
                client.BaseAddress = options.BaseAddress;
            });

        httpBuilderCallback?.Invoke(httpBuilder);

        return serviceCollection;
    }
}
