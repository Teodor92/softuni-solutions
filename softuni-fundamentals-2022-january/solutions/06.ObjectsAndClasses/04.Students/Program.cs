using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] lineParams = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                Student student = new Student
                {
                    FirstName = lineParams[0],
                    LastName = lineParams[1],
                    Age = int.Parse(lineParams[2]),
                    Hometown = lineParams[3]
                };

                students.Add(student);

                command = Console.ReadLine();
            }

            string hometown = Console.ReadLine();
            var filteredStudents = students.FindAll(student => student.Hometown == hometown);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
