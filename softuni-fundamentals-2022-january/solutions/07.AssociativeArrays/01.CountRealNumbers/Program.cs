using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // "33" "44" "55" 
            string[] rawInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = rawInput
                .Select(number => double.Parse(number))
                .ToList();

            // number -> how many times we saw it

            SortedDictionary<double, int> occurencies = new SortedDictionary<double, int>();

            // 33 44 33 44 22 3 4
            // test test text text e d a

            foreach (int number in numbers)
            {
                if (occurencies.ContainsKey(number))
                {
                    occurencies[number] += 1;
                }
                else
                {
                    occurencies.Add(number, 1);
                }
            }

            foreach (var item in occurencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
