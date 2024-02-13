using Vortex.Vehicles.UkVehicleData.Models;

namespace Vortex.Vehicles.UkVehicleData;

public interface IUkVehicleDataApiClient
{
    /// <summary>
    /// Gets the details of a vehicle for a given registration.
    /// </summary>
    /// <param name="registration">The registration for the vehicle.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The details of the vehicle that matches the given registration.</returns>
    Task<GetVehicleDataResponse> GetVehicleData(string registration, CancellationToken cancellationToken);
}
