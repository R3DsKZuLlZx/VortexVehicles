namespace Vortex.Vehicles.UkVehicleData.Models;

public class TechnicalSupport
{
    public string? ServerId { get; set; } 

    public string? RequestId { get; set; } 

    public decimal? QueryDurationMs { get; set; } 

    public string? SupportDate { get; set; } 

    public string? SupportTime { get; set; } 

    public string? SupportCode { get; set; }

    public List<string>? SupportInformationList { get; set; }
}
