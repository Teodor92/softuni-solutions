using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            string command = Console.ReadLine();

            int counter = 0;
            while (command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Contains":
                        int numberToContein = int.Parse(tokens[1]);
                        if (numbers.Contains(numberToContein))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                        Console.WriteLine(string.Join(" ", evenNumbers));       break;

                    case "PrintOdd":
                        List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        string action = tokens[1];
                        int numberToCompare = int.Parse(tokens[2]);
                        List<int> filteredList = GetFilteredList(numbers, action, numberToCompare);

                        Console.WriteLine(string.Join(" ", filteredList));
                        break;

                    case "Add":
                        int elementToAdd = int.Parse(tokens[1]);
                        numbers.Add(elementToAdd);
                        counter++;
                        break;

                    case "Remove":
                        int elementToRemove = int.Parse(tokens[1]);
                        numbers.Remove(elementToRemove); counter++;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        counter++;
                        break;

                    case "Insert":
                        int elementToInsert = int.Parse(tokens[1]);
                        int indexToInsertAt = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsertAt, elementToInsert); counter++;

                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static List<int> GetFilteredList(List<int> numbers, string action, int itemToCompare)
        {
            if (action == ">")
            {
                List<int> result = numbers.FindAll(x => x > itemToCompare);
                return result;
            }
            else if (action == "<")
            {
                List<int> result = numbers.FindAll(x => x < itemToCompare);
                return result;
            }
            else if (action == ">=")
            {
                List<int> result = numbers.FindAll(x => x >= itemToCompare);
                return result;

            }
            else if (action == "<=")
            {
                List<int> result = numbers.FindAll(x => x <= itemToCompare);
                return result;
            }

            return numbers;
        }
    }
}
