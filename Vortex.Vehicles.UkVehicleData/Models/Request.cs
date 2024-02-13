namespace Vortex.Vehicles.UkVehicleData.Models;

public class Request
{
    public string? RequestGuid { get; set; } 

    public string? PackageId { get; set; } 

    public decimal? PackageVersion { get; set; } 

    public decimal? ResponseVersion { get; set; } 

    public DataKeys? DataKeys { get; set; }
}
