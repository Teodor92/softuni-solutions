using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.0, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.5, "Good")]
    [TestCase(4.0, "Very Good")]
    [TestCase(4.5, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(-2.0, "Invalid!")]
    [TestCase(0, "Invalid!")]
    [TestCase(33.0, "Invalid!")]
    [TestCase(double.PositiveInfinity, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
