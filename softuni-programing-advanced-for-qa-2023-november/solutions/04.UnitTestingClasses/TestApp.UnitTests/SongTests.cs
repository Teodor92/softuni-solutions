using NUnit.Framework;

using System;
using System.Linq.Expressions;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void SetUp()
    {
        this._song = new();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        Song song = new Song();
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";

        // Act
        string result = song.AddAndListSongs(songs, "all");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song2";

        // Act
        string result = this._song.AddAndListSongs(songs, "Rock");

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = string.Empty;

        // Act
        string result = this._song.AddAndListSongs(songs, "Metal");

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsAreGiven()
    {
        // Arrange
        string[] songs = { };

        // Act
        string result = this._song.AddAndListSongs(songs, "Punk");

        // Assert
        Assert.AreEqual(string.Empty, result);
    }
}
