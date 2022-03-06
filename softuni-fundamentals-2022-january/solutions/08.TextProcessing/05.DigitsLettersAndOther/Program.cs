using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else
                {
                    others.Append(symbol);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
