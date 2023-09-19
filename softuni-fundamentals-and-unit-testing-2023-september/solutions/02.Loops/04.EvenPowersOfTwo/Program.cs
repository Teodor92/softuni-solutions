using System;

namespace _04.EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // Solution using Math.Pow
            //for (int i = 0; i <= number; i += 1)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(Math.Pow(2, i));
            //    }
            //}

            int num = 1;

            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
