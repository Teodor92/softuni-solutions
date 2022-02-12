using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameBoard = Console.ReadLine().Split().ToList();

            var command = Console.ReadLine();
            var turnCount = 0;

            while (command != "end")
            {
                turnCount++;
                var guessIndexes = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (IsCheatGuess(gameBoard, guessIndexes[0], guessIndexes[1]))
                {
                    gameBoard.Insert(gameBoard.Count / 2, $"-{turnCount}a");
                    gameBoard.Insert(gameBoard.Count / 2, $"-{turnCount}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (gameBoard[guessIndexes[0]] == gameBoard[guessIndexes[1]])
                {
                    var element = gameBoard[guessIndexes[0]];
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");

                    gameBoard.Remove(element);
                    gameBoard.Remove(element);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (gameBoard.Count == 0)
                {
                    Console.WriteLine($"You have won in {turnCount} turns!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (gameBoard.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", gameBoard));
            }
        }

        static bool IsCheatGuess(List<string> board, int firstGuess, int secondGuess)
        {
            if (firstGuess == secondGuess)
            {
                return true;
            }

            if (!IsIndexInBoard(board, firstGuess))
            {
                return true;
            }

            if (!IsIndexInBoard(board, secondGuess))
            {
                return true;
            }

            return false;
        }

        static bool IsIndexInBoard(List<string> board, int index)
        {
            return index >= 0 && index < board.Count;
        }
    }
}
