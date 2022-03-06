using System;
using System.Linq;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Normal way
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //string result = string.Empty;

            //foreach (var word in words)
            //{
            //    var repeatCount = word.Length;
            //    for (int i = 0; i < repeatCount; i++)
            //    {
            //        result += word;
            //    }
            //}

            //Console.WriteLine(result);

            // LINQ way
            var result = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .SelectMany(word => Enumerable
                                        .Range(0, word.Length)
                                        .Select(x => word));

            Console.WriteLine(string.Join("", result));
        }
    }
}
