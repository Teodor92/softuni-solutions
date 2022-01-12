using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (sum >= targetSum)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
