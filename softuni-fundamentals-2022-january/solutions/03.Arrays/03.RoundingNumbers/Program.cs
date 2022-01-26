using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] items = new double[rawInput.Length];

            for (int i = 0; i < rawInput.Length; i++)
            {
                items[i] = double.Parse(rawInput[i]);
            }

            // -0.00 - double - print 0.0

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
