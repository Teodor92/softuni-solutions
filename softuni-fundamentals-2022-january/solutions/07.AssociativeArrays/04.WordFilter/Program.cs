using System;
using System.Linq;

namespace _04.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                // "apple" "word" "text"
                .Where(word => word.Length % 2 == 0)
                .ToArray();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
