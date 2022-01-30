using System;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGradeMessage(grade);
        }

        static void PrintGradeMessage(double grade)
        {
            if (grade >= 2.0 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade > 2.99 && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade > 3.49 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade > 4.49 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade > 5.49 && grade <= 6.0)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
