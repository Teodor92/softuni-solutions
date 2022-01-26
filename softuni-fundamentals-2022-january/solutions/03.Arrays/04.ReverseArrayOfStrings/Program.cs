using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            Array.Reverse(items);

            Console.WriteLine(string.Join(" ", items));
        }
    }
}
