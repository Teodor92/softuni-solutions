using System;

namespace _03.Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = 1; number <= endNumber; number += 3) 
            {
                Console.WriteLine(number);
            }
        }
    }
}
