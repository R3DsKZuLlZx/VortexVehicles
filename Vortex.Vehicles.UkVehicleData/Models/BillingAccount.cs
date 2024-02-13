namespace Vortex.Vehicles.UkVehicleData.Models;

public class BillingAccount
{
    public string? AccountType { get; set; } 

    public decimal? AccountBalance { get; set; } 

    public decimal? TransactionCost { get; set; } 

    public ExtraInformation? ExtraInformation { get; set; }
}
