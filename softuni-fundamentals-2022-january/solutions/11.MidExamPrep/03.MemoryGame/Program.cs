using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            int moveCount = 0;

            while (command != "end")
            {
                moveCount++;
                string[] rawGuesses = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int firstGuess = int.Parse(rawGuesses[0]);
                int secondGuess = int.Parse(rawGuesses[1]);

                if (IsInvalidGuess(firstGuess, secondGuess, elements))
                {
                    int middleOfElemets = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElemets, elementToAdd);
                    elements.Insert(middleOfElemets, elementToAdd);
                }
                else if (elements[firstGuess] == elements[secondGuess])
                {
                    string guessedElement = elements[firstGuess];
                    elements.Remove(guessedElement);
                    elements.Remove(guessedElement);
                    // elements.RemoveAll(x => x == guessedElement);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElement}!");
                }
                else if (elements[firstGuess] != elements[secondGuess])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                }


                command = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        static bool IsInvalidGuess(int firstGuess, int secondGues, List<string> elemets)
        {
            return firstGuess == secondGues
                || !IsGuessInList(firstGuess, elemets)
                || !IsGuessInList(secondGues, elemets);
        }

        static bool IsGuessInList(int guess, List<string> elemets)
        {
            return guess >= 0 && guess < elemets.Count;
        }
    }
}
