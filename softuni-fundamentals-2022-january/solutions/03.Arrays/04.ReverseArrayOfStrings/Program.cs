using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] reversedArray = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[reversedArray.Length - 1 - i] = input[i];
            }

            Console.WriteLine(string.Join(" ", reversedArray));

            // Easier solution
            //Array.Reverse(input);
            //Console.WriteLine(string.Join(" ", input));
        }
    }
}
