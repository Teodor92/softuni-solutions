using System;

namespace _02.Numbers1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            for (int number = startingNumber; number >= 1; number -= 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
