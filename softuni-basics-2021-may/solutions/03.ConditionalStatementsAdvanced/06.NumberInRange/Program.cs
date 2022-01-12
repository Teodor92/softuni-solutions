using System;

namespace _06.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // [-100,100] != 0

            bool isInNumberRange = number >= -100 && number <= 100;
            bool notZero = number != 0;
            bool isInRange = isInNumberRange && notZero;

            if (isInRange)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
