using System;

namespace _01.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            // You can also make this a const!
            double excellentGrade = 5.50;

            if (grade >= excellentGrade)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
