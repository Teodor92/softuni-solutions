using System;
using System.Collections.Generic;

namespace _05.Students2
{
    internal class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Hometown { get; set; }
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] lineParams = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = lineParams[0];
                string lastName = lineParams[1];
                int age = int.Parse(lineParams[2]);
                string hometown = lineParams[3];

                if (DoesStudentExist(students, firstName, lastName))
                {
                    var exsistingStudent = GetExistingStudent(students, firstName, lastName);

                    exsistingStudent.FirstName = firstName;
                    exsistingStudent.LastName = lastName;
                    exsistingStudent.Age = age;
                    exsistingStudent.Hometown = hometown;
                }
                else
                {
                    Student student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string hometownToSearch = Console.ReadLine();
            var filteredStudents = students.FindAll(student => student.Hometown == hometownToSearch);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }

            return null;
        }
    }
}
