using System;

namespace _03.EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Could also be an integer
            double number = double.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
        }
    }
}
