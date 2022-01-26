using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 7 ok days, other Invalid day
            int dayNumber = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek = new string[]
            {
                "Monday", // 0
                "Tuesday", // 1
                "Wednesday", // 2
                "Thursday", // 3
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (dayNumber >= 1 && dayNumber <= daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
