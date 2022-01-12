
using System;

namespace _01_kino
{
    class Program
    {
        static void Main(string[] args)
        {

            string kinoTyp = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloms = int.Parse(Console.ReadLine());


            double priceForOnePlace = 0;

            switch (kinoTyp)
            {
                case "Premiere":
                    priceForOnePlace = 12;
                    break;
                case "Normal":
                    priceForOnePlace = 7.50; 
                    break;
                case "Discount":
                    priceForOnePlace = 5; 
                    break;
            }

            double Gewinn = priceForOnePlace * rows * coloms;

            Console.WriteLine($"{Gewinn:f2}leva");
        }
    }
}
