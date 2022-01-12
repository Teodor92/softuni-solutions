using System;

namespace _05.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string correctPassword = "s3cr3t!P@ssw0rd";

            if (password == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
