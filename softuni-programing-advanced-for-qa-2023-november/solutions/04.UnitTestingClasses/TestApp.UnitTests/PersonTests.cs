using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    // TODO: write the setup method

    // TODO: finish test
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };

        // Act
        //List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        //Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        //for (int i = 0; i < resultPeopleList.Count; i++)
        //{
        //    Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
        //    Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
        //    Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        //}
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // TODO: finish test
    }
}
