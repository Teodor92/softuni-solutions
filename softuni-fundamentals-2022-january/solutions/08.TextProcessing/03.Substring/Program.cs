using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                var startIndex = text.IndexOf(stringToRemove);
                text = text.Remove(startIndex, stringToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}
