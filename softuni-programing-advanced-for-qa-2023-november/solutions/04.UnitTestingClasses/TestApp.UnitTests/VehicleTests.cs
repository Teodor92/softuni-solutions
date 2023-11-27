using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{   
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        Vehicles vehicles = new Vehicles();

        string[] input =
        {
            "Car/Ford/Focus/120",
            "Car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500"
        };

        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_RetrunSortedCatalogue_WhenOnlyCarsAreGiven()
    {
        // Arrange
        Vehicles vehicles = new Vehicles();
        string[] input =
{
            "Car/Ford/Focus/120",
            "Car/Toyota/Camry/150",
        };

        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:";
        // Act
        string actual = vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue_WhenOnlyTrucksAreGiven()
    {
        // Arrange
        Vehicles vehicles = new Vehicles();
        string[] input = {
            "Truck/Volvo/VNL/500"
        };

        string expected = $"Cars:{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string actual = vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        Vehicles vehicles = new Vehicles();
        string[] input = { };
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string result = vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
