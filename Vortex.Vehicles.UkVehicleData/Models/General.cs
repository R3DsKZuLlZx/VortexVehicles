namespace Vortex.Vehicles.UkVehicleData.Models;

public class General
{
    public Engine? Engine { get; set; } 

    public string? PowerDelivery { get; set; } 

    public string? TypeApprovalCategory { get; set; } 

    public ElectricVehicleBattery? ElectricVehicleBattery { get; set; } 

    public string? SeriesDescription { get; set; } 

    public string? DriverPosition { get; set; } 

    public string? DrivingAxle { get; set; } 

    public decimal? DataVersionNumber { get; set; } 

    public string? EuroStatus { get; set; } 

    public bool? IsLimitedEdition { get; set; }
}
