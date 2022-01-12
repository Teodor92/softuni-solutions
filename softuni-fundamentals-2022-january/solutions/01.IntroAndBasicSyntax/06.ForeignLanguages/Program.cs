using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English"); break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
