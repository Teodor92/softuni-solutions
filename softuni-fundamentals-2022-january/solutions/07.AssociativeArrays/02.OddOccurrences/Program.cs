using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (frequencies.ContainsKey(wordInLowerCase))
                {
                    frequencies[wordInLowerCase] += 1;
                }
                else
                {
                    frequencies[wordInLowerCase] = 1;
                }
            }

            var filteredWords = frequencies
                .Where(item => item.Value % 2 != 0)
                .Select(item => item.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", filteredWords));
        }
    }
}
