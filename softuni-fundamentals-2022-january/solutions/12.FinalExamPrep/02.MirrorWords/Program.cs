using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(@|#)(?<firstWord>[a-zA-Z]{3,})(\1)(\1)(?<secondWord>[a-zA-Z]{3,})(\1)");
            List<string[]> mirrorPairs = new List<string[]>();
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["firstWord"].Value;
                string wordTwoReversed = string.Join("", match.Groups["secondWord"].Value.Reverse());

                if (wordOne == wordTwoReversed)
                {
                    mirrorPairs.Add(new string[2] { match.Groups["firstWord"].Value, match.Groups["secondWord"].Value });
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (mirrorPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorPairs.Select(x => $"{x[0]} <=> {x[1]}")));
            }
        }
    }
}
