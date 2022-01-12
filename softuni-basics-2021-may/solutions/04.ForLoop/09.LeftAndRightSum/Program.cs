using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceCount = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < sequenceCount; i++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }

            for (int i = 0; i < sequenceCount; i++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
