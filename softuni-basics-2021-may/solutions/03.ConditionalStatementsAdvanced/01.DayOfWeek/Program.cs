using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());

            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine();

            //if (dayOfTheWeek == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (dayOfTheWeek == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (dayOfTheWeek == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (dayOfTheWeek == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //else if (dayOfTheWeek == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //else if (dayOfTheWeek == 6)
            //{
            //    Console.WriteLine("Satarday");
            //}
            //else if (dayOfTheWeek == 7)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
        }
    }
}
