using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int workHour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((day == "Monday" || day == "Tuesday" ||
                day == "Wednesday" || day == "Thursday" ||
                day == "Friday" || day == "Saturday")
                && (workHour >= 10 && workHour <= 18))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
