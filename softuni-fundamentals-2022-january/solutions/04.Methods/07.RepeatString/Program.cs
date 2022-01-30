using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(inputString, repeatNumber));
        }

        static string RepeatString(string inputString, int repeatNumber)
        {
            string result = string.Empty;
            for (int i = 0; i < repeatNumber; i++)
            {
                result += inputString;
            }

            return result;
        }
    }
}
