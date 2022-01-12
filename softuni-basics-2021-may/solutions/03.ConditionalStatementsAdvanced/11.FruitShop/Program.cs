using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (dayOfTheWeek == "Monday" 
                || dayOfTheWeek == "Tuesday"
                || dayOfTheWeek == "Wednesday"
                || dayOfTheWeek == "Thursday"
                || dayOfTheWeek == "Friday")
            {

                //плод banana  apple orange  grapefruit kiwi    pineapple grapes
                //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85

                if (product == "banana")
                {
                    double finalPrice = quantity * 2.50;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "apple")
                {
                    double finalPrice = quantity * 1.20;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "orange")
                {
                    double finalPrice = quantity * 0.85;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "grapefruit")
                {
                    double finalPrice = quantity * 1.45;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "kiwi")
                {
                    double finalPrice = quantity * 2.70;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "pineapple")
                {
                    double finalPrice = quantity * 5.50;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "grapes")
                {
                    double finalPrice = quantity * 3.85;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                //плод banana  apple orange  grapefruit kiwi    pineapple grapes
                //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20


                if (product == "banana")
                {
                    double finalPrice = quantity * 2.70;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "apple")
                {
                    double finalPrice = quantity * 1.25;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "orange")
                {
                    double finalPrice = quantity * 0.90;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "grapefruit")
                {
                    double finalPrice = quantity * 1.60;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "kiwi")
                {
                    double finalPrice = quantity * 3.00;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "pineapple")
                {
                    double finalPrice = quantity * 5.60;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else if (product == "grapes")
                {
                    double finalPrice = quantity * 4.20;
                    Console.WriteLine($"{finalPrice:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
