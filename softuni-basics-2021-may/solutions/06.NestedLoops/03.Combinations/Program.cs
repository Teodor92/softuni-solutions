using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            // x1 + x2 + x3 = n
            // 22
            // x1/x2/x3 > 22 
            // 23 34 55 = 22

            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int x1 = 0; x1 <= number; x1++)
            {
                for (int x2 = 0; x2 <= number; x2++)
                {
                    for (int x3 = 0; x3 <= number; x3++)
                    {
                        if (x1 + x2 + x3 == number) 
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
