using System;
using System.Text;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringSlow(inputString, repeatNumber));
        }

        static string RepeatStringSlow(string inputString, int repeatNumber)
        {
            string result = string.Empty;
            for (int i = 0; i < repeatNumber; i++)
            {
                result += inputString;
            }

            return result;
        }

        static string RepeatStringFast(string inputString, int repeatNumber)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < repeatNumber; i++)
            {
                builder.Append(inputString);
            }

            return builder.ToString();
        }
    }
}
