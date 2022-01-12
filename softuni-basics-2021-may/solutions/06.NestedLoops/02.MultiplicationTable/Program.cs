using System;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    // i - 1
                    // j - 1,2,3,4...10

                    // i - 2
                    // j - 1,2,3...10

                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            // брой на външни завъртъния * брой на вътрешни завъртания
            // 10 * 10 = 100
            // 24 * 60 = 1440
        }
    }
}
