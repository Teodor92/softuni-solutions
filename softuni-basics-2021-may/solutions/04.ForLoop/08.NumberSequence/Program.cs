using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;
            int largerstNumber = int.MinValue;

            for (int i = 1; i <= numberOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                //smallestNumber = Math.Min(smallestNumber, number);
                //largerstNumber = Math.Max(largerstNumber, number);

                if (number > largerstNumber)
                {
                    largerstNumber = number;
                } 
                
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            Console.WriteLine($"Max number: {largerstNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
        }
    }
}
