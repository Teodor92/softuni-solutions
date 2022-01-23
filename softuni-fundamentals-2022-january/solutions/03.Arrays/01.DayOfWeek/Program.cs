using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeekNumber = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (dayOfTheWeekNumber < 1 || dayOfTheWeekNumber > daysOfTheWeek.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[dayOfTheWeekNumber - 1]);
            }
        }
    }
}
