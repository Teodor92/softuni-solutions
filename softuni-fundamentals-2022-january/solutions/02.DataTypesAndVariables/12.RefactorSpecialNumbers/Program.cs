using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int number = 1; number <= endNumber; number++)
            {
                int currentNumber = number;
                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
            }
        }
    }
}
