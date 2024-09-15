using DesignPatterns.Domain.Contracts;
using DesignPatterns.Domain.Creational.Builders;
using DesignPatterns.Domain.Entities;

IHouseBuilder builder = new ConcreteHouseBuilder();

House luxuryHouse = builder
            .SetRooms(5)
            .SetBathrooms(4)
            .BuildGarden()
            .BuildSwimmingPool()
            .SetRoofType("Gabled")
            .SetFlooringType("Marble")
            .AddSmartHomeFeatures()
            .AddEnergyEfficientInstallations()
            .Build();

Console.WriteLine(luxuryHouse);

// Building another type of house
House simpleHouse = builder
    .SetRooms(2)
    .SetBathrooms(1)
    .SetRoofType("Flat")
    .SetFlooringType("Laminate")
    .Build();

Console.WriteLine(simpleHouse);