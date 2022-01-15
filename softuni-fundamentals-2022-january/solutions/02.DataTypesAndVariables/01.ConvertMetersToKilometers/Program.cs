using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometeres = meters / 1000.0;
            Console.WriteLine($"{Math.Round(kilometeres, 2, MidpointRounding.AwayFromZero):F2}");
        }
    }
}
