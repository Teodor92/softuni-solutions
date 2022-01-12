using System;

namespace _00.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = (examHour * 60) + examMinutes;
            int studentTotalMintutes = (studentHour * 60) + studentMinutes;
            int minuteDifference = examTotalMinutes - studentTotalMintutes;

            if (minuteDifference < 0)
            {
                Console.WriteLine("Late");

                int hoursLate = Math.Abs(minuteDifference) / 60;
                int minutesLate = Math.Abs(minuteDifference) % 60;

                if (hoursLate > 0)
                {
                    Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(minuteDifference)} minutes after the start");
                }
            }
            else if (minuteDifference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Abs(minuteDifference)} minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");

                int hoursEarly = Math.Abs(minuteDifference) / 60;
                int minutesEarly = Math.Abs(minuteDifference) % 60;

                if (hoursEarly > 0)
                {
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(minuteDifference)} minutes before the start");
                }
            }
        }
    }
}
