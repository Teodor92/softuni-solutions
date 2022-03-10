using System;

namespace _001.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandParams = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = commandParams[0];

                if (action == "Contains")
                {
                    string wordToSearchFor = commandParams[1];

                    if (rawActivationKey.Contains(wordToSearchFor))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {wordToSearchFor}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string caseToFilp = commandParams[1];
                    int startIndex = int.Parse(commandParams[2]);
                    int endIndex = int.Parse(commandParams[3]);

                    string textToFilp = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (caseToFilp == "Lower")
                    {
                        textToFilp = textToFilp.ToLower();
                    }
                    else
                    {
                        textToFilp = textToFilp.ToUpper();
                    }

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = rawActivationKey.Insert(startIndex, textToFilp);

                    Console.WriteLine(rawActivationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandParams[1]);
                    int endIndex = int.Parse(commandParams[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActivationKey);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
