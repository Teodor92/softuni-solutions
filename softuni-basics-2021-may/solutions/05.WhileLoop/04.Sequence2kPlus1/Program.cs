using System;

namespace _04.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            while (currentNumber <= endNumber)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2 + 1;
            }
        }
    }
}
