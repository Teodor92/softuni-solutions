using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
