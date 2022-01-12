using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double totalDogFoodPrice = dogCount * 2.5;
            double totalOtherAnimalFoodPrice = otherAnimalsCount * 4.0;

            double totalFoodPrice = totalDogFoodPrice + totalOtherAnimalFoodPrice;

            //Console.WriteLine(totalFoodPrice + " lv.");
            Console.WriteLine($"{totalFoodPrice} lv.");
        }
    }
}
