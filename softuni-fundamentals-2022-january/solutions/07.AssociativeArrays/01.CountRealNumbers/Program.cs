using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> frequencies = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (frequencies.ContainsKey(number))
                {
                    frequencies[number] += 1;
                }
                else
                {
                    frequencies[number] = 1;
                }
            }

            foreach (var item in frequencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
