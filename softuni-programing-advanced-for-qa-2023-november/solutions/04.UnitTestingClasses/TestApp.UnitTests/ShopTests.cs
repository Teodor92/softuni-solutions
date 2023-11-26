using NUnit.Framework;

using System;

using TestApp.Store;

namespace TestApp.UnitTests;

public class ShopTests
{
    // TODO: write setup method

    // TODO: finish test
    [Test]
    public void Test_AddAndGetBoxes_ReturnsSortedBoxes()
    {
        // Arrange
        string expected = $"12345{Environment.NewLine}-- Widget - $10.00: 5{Environment.NewLine}-- $50.00{Environment.NewLine}54321{Environment.NewLine}-- Gadget - $15.00: 3{Environment.NewLine}-- $45.00{Environment.NewLine}98765{Environment.NewLine}-- Gizmo - $8.00: 2{Environment.NewLine}-- $16.00";

        // Act
        //string result = this._shop.AddAndGetBoxes(products);

        // Assert
        //Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetBoxes_ReturnsEmptyString_WhenNoProductsGiven()
    {
        // TODO: finish test
    }
}
