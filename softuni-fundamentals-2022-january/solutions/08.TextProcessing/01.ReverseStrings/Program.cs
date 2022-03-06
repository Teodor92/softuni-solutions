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
                char[] charCommand = command.ToCharArray();
                Array.Reverse(charCommand);
                string result = new string(charCommand);

                Console.WriteLine($"{command} = {result}");

                command = Console.ReadLine();
            }
        }
    }
}
