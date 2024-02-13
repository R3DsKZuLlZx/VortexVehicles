namespace Vortex.Vehicles.UkVehicleData.Models;

public class Response
{
    public string? StatusCode { get; set; } 

    public string? StatusMessage { get; set; } 

    public StatusInformation? StatusInformation { get; set; } 

    public DataItems? DataItems { get; set; }
}
