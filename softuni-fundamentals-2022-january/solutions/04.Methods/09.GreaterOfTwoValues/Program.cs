using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int outputLarger = GetIntMax(first, second);
                Console.WriteLine(outputLarger);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char outputLarger = GetCharMax(first, second);
                Console.WriteLine(outputLarger);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string outputLarger = GetStringMax(first, second);
                Console.WriteLine(outputLarger);
            }
        }

        static int GetIntMax(int first, int second)
        {
            return first >= second ? first : second;
        }

        static char GetCharMax(char first, char second)
        {
            return first >= second ? first : second;
        }

        static string GetStringMax(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}
