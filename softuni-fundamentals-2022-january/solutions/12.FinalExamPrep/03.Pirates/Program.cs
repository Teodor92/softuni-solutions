using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class City
    {
        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> pirates = new Dictionary<string, City>();
            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] commandArgs = command.Split("||");
                string town = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);
                if (!pirates.ContainsKey(town))
                {
                    pirates.Add(town, new City(town, population, gold));
                }
                else
                {
                    pirates[town].Population += population;
                    pirates[town].Gold += gold;


                }

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();
            while (secondCommand != "End")
            {
                string[] commandArgs = secondCommand.Split("=>");
                string action = commandArgs[0];

                if (action == "Plunder")
                {
                    string town = commandArgs[1];
                    int population = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    pirates[town].Population -= population;
                    pirates[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (pirates[town].Population == 0 || pirates[town].Gold == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        pirates.Remove(town);
                    }
                }
                else if (action == "Prosper")
                {
                    string town = commandArgs[1];
                    int gold = int.Parse(commandArgs[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        pirates[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pirates[town].Gold} gold.");
                    }
                }

                secondCommand = Console.ReadLine();
            }

            if (pirates.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");
                foreach (var item in pirates)
                {
                    var city = item.Value;
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
