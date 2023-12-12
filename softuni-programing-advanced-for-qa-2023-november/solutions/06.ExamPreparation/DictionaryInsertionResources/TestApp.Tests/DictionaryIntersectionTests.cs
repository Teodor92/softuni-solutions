using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrage
        Dictionary<string, int> firstDictonary = new Dictionary<string, int>();
        Dictionary<string, int> secondDictonary = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);

        // Assert
        Assert.AreEqual(0, result.Count);
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };

        Dictionary<string, int> secondDictonary = new();

        // Act

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);

        // Assert
        Assert.AreEqual(0, result.Count);
        Assert.IsTrue(result.Count == 0);
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };

        Dictionary<string, int> secondDictonary = new()
        {
            { "three", 3 },
            { "four", 4 },
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> fisrtDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
            { "six", 6 },
        };
        Dictionary<string, int> secondDictonary = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "four", 4 },
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(fisrtDictonary, secondDictonary);

        // Assert
        Assert.AreEqual(2, result.Count);

        Assert.IsTrue(result.ContainsKey("one"));
        Assert.AreEqual(1, result["one"]);

        Assert.IsTrue(result.ContainsKey("two"));
        Assert.AreEqual(2, result["two"]);

        Assert.IsFalse(result.ContainsKey("four"));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };

        Dictionary<string, int> secondDictonary = new()
        {
            { "one", 10 },
            { "two", 20 },
        };

        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);

        // Assert
        //Assert.AreEqual(expected, result);
        Assert.AreEqual(0, result.Count);
        Assert.That(result, Is.Empty);
        Assert.IsTrue(!result.Any());
    }
}
