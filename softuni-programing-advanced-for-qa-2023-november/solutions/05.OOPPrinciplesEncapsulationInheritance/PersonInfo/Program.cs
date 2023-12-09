using PersonInfo;

using System;
using System.Collections.Generic;
using System.Linq;

int lines = int.Parse(Console.ReadLine()!);

List<Person> persons = new List<Person>();
for (int i = 0; i < lines; i++)
{
    string[] cmd = Console.ReadLine()!.Split();
    Person person = new(cmd[0], cmd[1], int.Parse(cmd[2]));
    persons.Add(person);
}

persons
    .OrderBy(p => p.FirstName)
    .ThenBy(p => p.Age)
    .ToList()
    .ForEach(x => Console.WriteLine(x));
