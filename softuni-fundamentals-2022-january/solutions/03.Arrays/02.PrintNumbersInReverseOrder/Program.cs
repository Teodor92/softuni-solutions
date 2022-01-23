using System;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            string[] allNumbers = new string[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {
                allNumbers[i] = Console.ReadLine();
            }

            for (int i = allNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{allNumbers[i]} ");
            }
        }
    }
}
