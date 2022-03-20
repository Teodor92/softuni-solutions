using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = @"\+359([ -])2\1\d{3}\1\d{4}";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, expression);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
