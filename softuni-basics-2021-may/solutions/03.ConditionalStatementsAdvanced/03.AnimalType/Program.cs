using System;

namespace _03.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.dog->mammal
            //2.crocodile, tortoise, snake->reptile
            //3.others->unknown

            int test = 2;
            if (test % 2 == 0)
            {
                // even
            }
            else
            {
                // odd
            }

            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
