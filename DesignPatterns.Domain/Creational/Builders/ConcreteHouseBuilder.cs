using DesignPatterns.Domain.Contracts;
using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Domain.Creational.Builders;

public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public IHouseBuilder SetRooms(int number)
    {
        _house.Rooms = number;
        return this;
    }

    public IHouseBuilder SetBathrooms(int number)
    {
        _house.Bathrooms = number;
        return this;
    }

    public IHouseBuilder BuildGarden()
    {
        _house.HasGarden = true;
        return this;
    }

    public IHouseBuilder BuildSwimmingPool()
    {
        _house.HasSwimmingPool = true;
        return this;
    }

    public IHouseBuilder SetRoofType(string type)
    {
        _house.RoofType = type;
        return this;
    }

    public IHouseBuilder SetFlooringType(string type)
    {
        _house.FlooringType = type;
        return this;
    }

    public IHouseBuilder AddSmartHomeFeatures()
    {
        _house.HasSmartHomeFeatures = true;
        return this;
    }

    public IHouseBuilder AddEnergyEfficientInstallations()
    {
        _house.HasEnergyEfficientInstallations = true;
        return this;
    }

    public House Build()
    {
        return _house;
    }
}

