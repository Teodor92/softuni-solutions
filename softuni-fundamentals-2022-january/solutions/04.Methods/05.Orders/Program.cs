using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string product, int number)
        {
            if (product == "coffee")
            {
                decimal price = number * 1.50m;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "water")
            {
                decimal price = number * 1.00m;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "coke")
            {
                decimal price = number * 1.40m;
                Console.WriteLine($"{price:F2}");
            }
            else if (product == "snacks")
            {
                decimal price = number * 2.00m;
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
