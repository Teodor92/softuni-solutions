using System;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
