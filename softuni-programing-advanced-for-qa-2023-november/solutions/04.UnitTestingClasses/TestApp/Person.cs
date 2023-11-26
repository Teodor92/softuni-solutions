using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

public class Person
{
    public string Name { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int Age { get; set; }

    public List<Person> AddPeople(string[] people)
    {
        List<Person> peopleList = new();
        foreach (string data in people)
        {
            string[] split = data.Split();

            string name = split[0];
            string id = split[1];
            int age = int.Parse(split[2]);

            Person? searchPerson = peopleList.FirstOrDefault(person => person.Id == id);
            if (searchPerson is null)
            {
                peopleList.Add(new()
                {
                    Name = name,
                    Id = id,
                    Age = age
                });
            }
            else
            {
                searchPerson.Age = age;
                searchPerson.Name = name;
            }
        }

        return peopleList;
    }

    public string GetByAgeAscending(List<Person> people)
    {
        StringBuilder sb = new();
        foreach (Person person in people.OrderBy(person => person.Age))
        {
            sb.AppendLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
        }

        return sb.ToString().Trim();
    }
}
