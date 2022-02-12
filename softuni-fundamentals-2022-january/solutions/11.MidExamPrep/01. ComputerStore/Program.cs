using System;

namespace _01._ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            decimal priceWithoutTax = 0;

            while (command != "special" && command != "regular")
            {
                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                priceWithoutTax += price;

                command = Console.ReadLine();
            }

            if (priceWithoutTax == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                decimal taxes = priceWithoutTax * 0.2m;

                Console.WriteLine("Congratulations you've just bought a new computer!");

                Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");

                if (command == "special")
                {
                    decimal finalPrice = (priceWithoutTax + taxes) * 0.9m;
                    Console.WriteLine($"Total price: {finalPrice:F2}$");
                }
                else
                {
                    decimal finalPrice = priceWithoutTax + taxes;
                    Console.WriteLine($"Total price: {finalPrice:F2}$");
                }
            }
        }
    }
}
