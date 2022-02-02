using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleHight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleHight; i++)
            {
                PrintLine(1, i);
            }

            for (int i = triangleHight - 1; i >= 1 ; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
