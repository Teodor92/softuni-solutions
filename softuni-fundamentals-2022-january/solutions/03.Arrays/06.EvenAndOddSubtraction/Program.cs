using System;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            int[] items = new int[rawInput.Length];

            for (int i = 0; i < rawInput.Length; i++)
            {
                items[i] = int.Parse(rawInput[i]);
            }

            int evenSum = 0;
            int oddSum = 0;

            foreach (int item in items)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
