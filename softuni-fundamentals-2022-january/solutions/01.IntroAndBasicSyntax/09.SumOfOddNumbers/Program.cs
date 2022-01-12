using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentOddNumber = 1 + (2 * i);
                Console.WriteLine(currentOddNumber);
                oddSum += currentOddNumber;
            }

            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
