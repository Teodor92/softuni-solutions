using System;
using System.Linq;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandTokens = command.Split();

                if (commandTokens[0] == "TakeOdd")
                {
                    var oddChars = password.Where((character, index) => index % 2 != 0);
                    password = string.Join(string.Empty, oddChars);
                }
                else if (commandTokens[0] == "Cut")
                {
                    int index = int.Parse(commandTokens[1]);
                    int length = int.Parse(commandTokens[2]);

                    string substring = password.Substring(index, length);
                    int place = password.IndexOf(substring);
                    password = password.Remove(place, substring.Length);
                }
                else if (commandTokens[0] == "Substitute")
                {
                    string substring = commandTokens[1];
                    string substitute = commandTokens[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        command = Console.ReadLine();
                        continue;
                    }
                }

                Console.WriteLine(password);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
