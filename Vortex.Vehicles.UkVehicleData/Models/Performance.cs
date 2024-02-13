namespace Vortex.Vehicles.UkVehicleData.Models;

public class Performance
{
    public Torque? Torque { get; set; } 

    public object? NoiseLevel { get; set; } 

    public decimal? DataVersionNumber { get; set; } 

    public Power? Power { get; set; } 

    public MaxSpeed? MaxSpeed { get; set; } 

    public decimal? Co2 { get; set; } 

    public object? Particles { get; set; } 

    public Acceleration? Acceleration { get; set; }
}
