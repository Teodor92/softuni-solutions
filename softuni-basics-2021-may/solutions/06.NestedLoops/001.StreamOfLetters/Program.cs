using System;

namespace _001.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            string currentWord = "";
            bool letterCHasBeenFound = false;
            bool letterNHasBeenFound = false;
            bool letterOHasBeenFound = false;

            while (letter != "End")
            {
                // "a" -> 'a'

                char parsedLetter = char.Parse(letter);

                if (char.IsLetter(parsedLetter))
                {
                    if (parsedLetter == 'c' && !letterCHasBeenFound)
                    {
                        letterCHasBeenFound = true;
                    }
                    else if (parsedLetter == 'n' && !letterNHasBeenFound)
                    {
                        letterNHasBeenFound = true;
                    }
                    else if (parsedLetter == 'o' && !letterOHasBeenFound)
                    {
                        letterOHasBeenFound = true;
                    }
                    else
                    {
                        currentWord += parsedLetter;
                    }

                    if (letterOHasBeenFound && letterCHasBeenFound && letterNHasBeenFound)
                    {
                        Console.Write(currentWord);
                        Console.Write(" ");

                        currentWord = "";
                        letterCHasBeenFound = false;
                        letterNHasBeenFound = false;
                        letterOHasBeenFound = false;
                    }
                }

                letter = Console.ReadLine();
            }
        }
    }
}
