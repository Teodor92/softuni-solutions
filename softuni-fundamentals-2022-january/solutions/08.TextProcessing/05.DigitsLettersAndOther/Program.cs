using System;
using System.Linq;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder letters = new StringBuilder();
            //StringBuilder numbers = new StringBuilder();
            //StringBuilder otherChars = new StringBuilder();

            string text = Console.ReadLine();

            char[] allDigits = text
                .Where(item => char.IsDigit(item))
                .ToArray();

            char[] allLetters = text
                .Where((item) => char.IsLetter(item))
                .ToArray();

            char[] otherChars = text
                .Where((item) => !char.IsLetterOrDigit(item))
                .ToArray();

            Console.WriteLine(string.Join("", allDigits));
            Console.WriteLine(allDigits.ToString());
            Console.WriteLine(allLetters);
            Console.WriteLine(otherChars);

            //foreach (char item in text)
            //{
            //    if (char.IsLetter(item))
            //    {
            //        letters.Append(item);
            //    }
            //    else if (char.IsDigit(item))
            //    {
            //        numbers.Append(item);
            //    }
            //    else
            //    {
            //        otherChars.Append(item);
            //    }
            //}

            //Console.WriteLine(numbers.ToString());
            //Console.WriteLine(letters.ToString());
            //Console.WriteLine(otherChars.ToString());
        }
    }
}
