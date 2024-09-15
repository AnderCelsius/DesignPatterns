namespace DesignPatterns.Domain.Entities;

public class House
{
    public int Rooms { get; set; }
    public int Bathrooms { get; set; }
    public bool HasGarden { get; set; }
    public bool HasSwimmingPool { get; set; }
    public string RoofType { get; set; }
    public string FlooringType { get; set; }
    public bool HasSmartHomeFeatures { get; set; }
    public bool HasEnergyEfficientInstallations { get; set; }

    public override string ToString()
    {
        return $"House with {Rooms} rooms, {Bathrooms} bathrooms, " +
               $"{(HasGarden ? "a garden, " : "")}" +
               $"{(HasSwimmingPool ? "a swimming pool, " : "")}" +
               $"roof type: {RoofType}, flooring: {FlooringType}, " +
               $"{(HasSmartHomeFeatures ? "smart home features, " : "")}" +
               $"{(HasEnergyEfficientInstallations ? "energy-efficient installations." : "")}";
    }
}

