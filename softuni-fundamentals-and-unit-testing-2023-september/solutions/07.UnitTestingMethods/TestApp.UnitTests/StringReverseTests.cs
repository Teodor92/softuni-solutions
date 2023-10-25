using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    // Arrange
    // 1. Navigate to product page
    // 2. Apply filter for resent products
    // Act
    // 1. Data from the web page
    // Assert
    // 1. Do we have 8 recent product?

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("X", result);
        Assert.AreEqual(1, result.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "XYZ";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, result.Length);
        Assert.AreEqual("ZYX", result);
    }
}
