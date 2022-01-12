using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            while (true)
            {
                // 111.11 | -123123 | "NoMoreMoney"
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {totalSum:F2}");
                    break;
                }

                double deposit = double.Parse(input);

                if (deposit >= 0)
                {
                    Console.WriteLine($"Increase: {deposit:F2}");
                    totalSum += deposit;
                }
                else
                {
                    // Invalid operation!
                    //Total: 165.55
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {totalSum:F2}");
                    break;
                }
            }
        }
    }
}
