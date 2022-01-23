using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allNumbersRaw = Console.ReadLine().Split();
            double[] allNumbers = new double[allNumbersRaw.Length];

            for (int i = 0; i < allNumbersRaw.Length; i++)
            {
                allNumbers[i] = double.Parse(allNumbersRaw[i]);
            }

            for (int i = 0; i < allNumbers.Length; i++)
            {
                Console.WriteLine($"{allNumbers[i]} => {Math.Round(allNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
