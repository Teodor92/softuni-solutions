using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArgs = command.Split(":|:");
                string type = commandArgs[0];

                if (type == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);
                    message = message.Insert(index, " ");
                }
                else if (type == "Reverse")
                {
                    string substring = commandArgs[1];

                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (type == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
