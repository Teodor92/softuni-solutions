using System;

namespace _02.WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
