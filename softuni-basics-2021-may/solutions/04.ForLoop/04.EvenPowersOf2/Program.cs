using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPower = int.Parse(Console.ReadLine());

            for (int power = 0; power <= endPower; power += 2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }

            //for (int power = 0; power <= endPower; power++)
            //{
            //    if (power % 2 == 0)
            //    {
            //        Console.WriteLine(Math.Pow(2, power));
            //    }
            //}
        }
    }
}
