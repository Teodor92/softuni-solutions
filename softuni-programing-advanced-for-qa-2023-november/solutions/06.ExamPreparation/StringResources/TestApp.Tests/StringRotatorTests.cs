using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrane
        string input = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, 99);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Hello!";
        int positions = 0;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = 2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = -2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = 2 + (input.Length * 2);

        // Hello! 6 -> Hello!
        // Hello! 12 -> Hello!
        // Hello! 12 + 2 -> o!Hell

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
