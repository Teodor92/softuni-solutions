using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demos
{
    class Program
    {
        class Student
        {
            public Student(string name, int age, bool isActive)
            {
                this.Name = name;
                this.Age = age;
                this.IsActive = isActive;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public bool IsActive { get; set; }

            public List<int> Grade { get; set; } = new List<int>();
        }

        static void Main(string[] args)
        {
            var studentOne = new Student("Ivan", 15, true);

            studentOne.Grade.Add(5);

            var secondStudent = new Student("Stamat", 16, true);
            var studentThree = new Student("Maria", 17, true);
            var studentFour = new Student("John", 13, true);
            var studentFive = new Student("Eli", 15, false);

            List<Student> students = new List<Student>()
            {
                studentOne,
                secondStudent,
                studentThree,
                studentFour,
                studentFive
            };

            // 1. All the names of the student that are above 14 years

            var above14Students = students
                .Where(student => student.Age > 14)
                .Select(student => student.Name)
                .ToArray();

            Console.WriteLine(string.Join(" ", above14Students));

            // 2. All the name of the students that are active

            var allActiveStudents = students
                .Where(student => student.IsActive)
                .Select(student => student.Name)
                .ToArray();

            Console.WriteLine(string.Join(" ", allActiveStudents));

            // 3. All the name of the students that are inactive

            var allInactiveStudents = students
                .Where(student => !student.IsActive)
                .Select(student => student.Name)
                .ToArray();

            Console.WriteLine(string.Join(" ", allInactiveStudents));

            // 4. The average age of all students

            var averageAge = students
                .Select(student => student.Age)
                .Average();

            //var averageAge = students
            //    .Average(student => student.Age);

            Console.WriteLine(averageAge);

            // 5. Are there any inactive students?

            bool inactiveExists = students
                .Any(student => !student.IsActive);

            List<bool> stauts = students.Select(x => x.IsActive).ToList();

            int inactiveCount = students
                .Count(student => !student.IsActive);

            List<int> values = new List<int>{ 1, 2, 3 };
            Console.WriteLine(values.Contains(2));
            Console.WriteLine(values.Any(x => x == 2));


            Dictionary<string, Dictionary<string, List<int>>> complexDic = new Dictionary<string, Dictionary<string, List<int>>>();

            complexDic["test"]["test"].Add(123);
        }
    }
}
