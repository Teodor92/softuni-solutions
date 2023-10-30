using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = 1;
        double firstPointY = 1;
        double secondPointX = 2;
        double secondPointY = 2;

        string expected = $"({firstPointX}, {firstPointY})";
        // Act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstPointX = 2;
        double firstPointY = 2;
        double secondPointX = 1;
        double secondPointY = 1;

        string expected = $"({secondPointX}, {secondPointY})";
        // Act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = 1;
        double firstPointY = 1;
        double secondPointX = 1;
        double secondPointY = 1;

        string expected = $"({firstPointX}, {firstPointY})";
        // Act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = -1;
        double firstPointY = -1;
        double secondPointX = 1;
        double secondPointY = 1;

        string expected = $"({firstPointX}, {firstPointY})";
        // Act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstPointX = 2;
        double firstPointY = 2;
        double secondPointX = -2;
        double secondPointY = -2;

        string expected = $"({secondPointX}, {secondPointY})";
        // Act

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
