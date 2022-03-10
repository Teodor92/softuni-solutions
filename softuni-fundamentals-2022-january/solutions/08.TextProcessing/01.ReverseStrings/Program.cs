using System;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                char[] wordArr = command.ToCharArray();
                Array.Reverse(wordArr);
                string reversedWord = new string(wordArr);

                Console.WriteLine($"{command} = {reversedWord}");

                command = Console.ReadLine();
            }
        }
    }
}
