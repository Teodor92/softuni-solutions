using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int[] secondArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += secondArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                    // Environment.Exit(0);
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
