namespace Vortex.Vehicles.UkVehicleData.Models;

public class MotVed
{
    public VedRate? VedRate { get; set; } 

    public decimal? VedCo2Emissions { get; set; } 

    public DateTime? MotDue { get; set; } 

    public string? VedBand { get; set; } 

    public string? VedCo2Band { get; set; } 

    public DateTime? TaxDue { get; set; } 

    public string? Message { get; set; } 

    public string? VehicleStatus { get; set; }
}
