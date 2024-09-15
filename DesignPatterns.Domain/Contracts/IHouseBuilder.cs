using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.Contracts;

public interface IHouseBuilder
{
    IHouseBuilder SetRooms(int number);
    IHouseBuilder SetBathrooms(int number);
    IHouseBuilder BuildGarden();
    IHouseBuilder BuildSwimmingPool();
    IHouseBuilder SetRoofType(string type);
    IHouseBuilder SetFlooringType(string type);
    IHouseBuilder AddSmartHomeFeatures();
    IHouseBuilder AddEnergyEfficientInstallations();
    House Build();
}

