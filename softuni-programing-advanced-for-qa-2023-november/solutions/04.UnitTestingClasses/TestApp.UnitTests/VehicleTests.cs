using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    // TODO: write the setup method

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        //string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        //Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // TODO: finish test
    }
}
