using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int totalSum = 0;
            bool differenceFound = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    differenceFound = true;
                    break;
                }
                else
                {
                    totalSum += firstArray[i];
                }
            }

            if (!differenceFound)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }
        }
    }
}
