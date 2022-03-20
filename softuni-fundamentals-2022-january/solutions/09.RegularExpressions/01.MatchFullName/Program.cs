using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(names);

            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}
