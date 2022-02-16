using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] splitCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = splitCommand[0];

                if (action == "Fire")
                {
                    int attackWarShipIndex = int.Parse(splitCommand[1]);
                    int attackDamage = int.Parse(splitCommand[2]);

                    if (attackWarShipIndex >= 0 && attackWarShipIndex < warShip.Count)
                    {
                        warShip[attackWarShipIndex] -= attackDamage;
                        if (warShip[attackWarShipIndex] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startPirateIndex = int.Parse(splitCommand[1]);
                    int endPirateIndex = int.Parse(splitCommand[2]);
                    int attackDamage = int.Parse(splitCommand[3]);

                    if (startPirateIndex >= 0
                        && startPirateIndex < pirateShip.Count
                        && endPirateIndex >= 0
                        && endPirateIndex < pirateShip.Count)
                    {
                        for (int i = startPirateIndex; i <= endPirateIndex; i++)
                        {
                            pirateShip[i] -= attackDamage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int pirateShipIndex = int.Parse(splitCommand[1]);
                    int repairValue = int.Parse(splitCommand[2]);

                    if (pirateShipIndex >= 0 && pirateShipIndex < pirateShip.Count)
                    {
                        if (pirateShip[pirateShipIndex] + repairValue > maxHealth)
                        {
                            pirateShip[pirateShipIndex] = maxHealth;
                        }
                        else
                        {
                            pirateShip[pirateShipIndex] += repairValue;
                        }
                    }
                }
                else if (action == "Status")
                {
                    List<int> sectionsInNeedOfRepare = pirateShip
                        .FindAll(x => (x < maxHealth * 0.2));
                    Console.WriteLine($"{sectionsInNeedOfRepare.Count} sections need repair.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
