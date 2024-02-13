namespace Vortex.Vehicles.UkVehicleData.Models;

public class GetVehicleDataResponse
{
    public BillingAccount? BillingAccount { get; set; } 

    public TechnicalSupport? TechnicalSupport { get; set; } 

    public Request? Request { get; set; } 

    public Response? Response { get; set; }
    
    public AuthenticationFailureDetails? AuthenticationFailureDetails { get; set; }
}
