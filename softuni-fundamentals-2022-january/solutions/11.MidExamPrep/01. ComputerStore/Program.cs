using System;

namespace _01._ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            decimal totalPriceWithNoTax = 0;

            while (command != "regular" && command != "special")
            {
                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalPriceWithNoTax += price;

                command = Console.ReadLine();
            }

            if (totalPriceWithNoTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal taxes = totalPriceWithNoTax * 0.2m;

            if (command == "special")
            {
                decimal totalWithTaxes = totalPriceWithNoTax + taxes;
                decimal totalPriceWithDiscount = totalWithTaxes * 0.9m;

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithNoTax:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithDiscount:F2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithNoTax:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPriceWithNoTax + taxes):F2}$");
            }
        }
    }
}
