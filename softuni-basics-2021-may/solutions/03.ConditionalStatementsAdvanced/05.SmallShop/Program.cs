using System;

namespace _05.SmallShop
{
    class Program
    {
        //град / продукт coffee  water beer    sweets peanuts
        //Sofia	        0.50	0.80	1.20	1.45	1.60
        //Plovdiv	        0.40	0.70	1.15	1.30	1.50
        //Varna	        0.45	0.70	1.10	1.35	1.55


        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    productPrice = 0.50;
                }
                else if (product == "water")
                {
                    productPrice = 0.80;
                }
                else if (product == "beer")
                {
                    productPrice = 1.20;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.45;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.60;
                }
                else
                {
                    Console.WriteLine("Invalid product!");
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productPrice = 0.40;
                }
                else if (product == "water")
                {
                    productPrice = 0.70;
                }
                else if (product == "beer")
                {
                    productPrice = 1.15;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.30;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.50;
                }
                else
                {
                    Console.WriteLine("Invalid product!");
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    productPrice = 0.45;
                }
                else if (product == "water")
                {
                    productPrice = 0.70;
                }
                else if (product == "beer")
                {
                    productPrice = 1.10;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.35;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.55;
                }
                else
                {
                    Console.WriteLine("Invalid product!");
                }
            }
            else
            {
                Console.WriteLine("Invalid city");
            }

            Console.WriteLine(quantity * productPrice);
        }
    }
}
