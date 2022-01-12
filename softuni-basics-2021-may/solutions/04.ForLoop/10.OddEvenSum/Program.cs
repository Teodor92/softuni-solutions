using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int position = 0; position < sequenceCount; position++)
            {
                int number = int.Parse(Console.ReadLine());

                if (position % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
