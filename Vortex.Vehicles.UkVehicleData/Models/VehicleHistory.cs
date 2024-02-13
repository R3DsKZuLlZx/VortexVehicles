namespace Vortex.Vehicles.UkVehicleData.Models;

public class VehicleHistory
{
    public decimal? V5CCertificateCount { get; set; } 

    public decimal? PlateChangeCount { get; set; } 

    public decimal? NumberOfPreviousKeepers { get; set; } 

    public List<V5CCertificateList>? V5CCertificateList { get; set; } 

    public decimal? KeeperChangesCount { get; set; } 

    public decimal? VicCount { get; set; } 

    public decimal? ColourChangeCount { get; set; } 

    public object? ColourChangeList { get; set; } 

    public object? KeeperChangesList { get; set; } 

    public object? PlateChangeList { get; set; } 

    public object? VicList { get; set; }
}
