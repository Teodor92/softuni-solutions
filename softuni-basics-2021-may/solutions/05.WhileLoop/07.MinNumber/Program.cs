using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            // 123123 | "Stop"
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
