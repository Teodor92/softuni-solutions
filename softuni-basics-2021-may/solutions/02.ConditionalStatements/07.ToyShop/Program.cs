using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaccationCost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int toys = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int toysCount = puzzles + dolls + bears + toys + trucks;
            double profit = puzzles * 2.60 + dolls * 3 + bears * 4.10 + toys * 8.20 + trucks * 2;

            if (toysCount >= 50)
            {
                profit = profit * 0.75;
            }

            profit = profit * 0.9;

            if (profit >= vaccationCost)
            {
                Console.WriteLine($"Yes! {(profit - vaccationCost):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vaccationCost - profit):F2} lv needed.");
            }
        }
    }
}
