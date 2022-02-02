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
                int outputLarger = GetMax(first, second);
                Console.WriteLine(outputLarger);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char outputLarger = GetMax(first, second);
                Console.WriteLine(outputLarger);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string outputLarger = GetMax(first, second);
                Console.WriteLine(outputLarger);
            }
        }

        static int GetMax(int first, int second)
        {
            return first >= second ? first : second;
        }

        static char GetMax(char first, char second)
        {
            return first >= second ? first : second;
        }

        static string GetMax(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}
