using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mazeRooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int heroHealth = 100;
            int heroCoins = 0;

            for (int i = 0; i < mazeRooms.Length; i++)
            {
                string[] splitCommand = mazeRooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = splitCommand[0];

                if (action == "potion")
                {
                    int healthToHeal = int.Parse(splitCommand[1]);

                    if (healthToHeal + heroHealth > 100)
                    {
                        int healthHealed = 100 - heroHealth;
                        heroHealth = 100;
                        Console.WriteLine($"You healed for {healthHealed} hp.");
                        Console.WriteLine($"Current health: {heroHealth} hp.");
                    }
                    else
                    {
                        heroHealth += healthToHeal;
                        Console.WriteLine($"You healed for {healthToHeal} hp.");
                        Console.WriteLine($"Current health: {heroHealth} hp.");
                    }
                }
                else if (action == "chest")
                {
                    int coins = int.Parse(splitCommand[1]);
                    heroCoins += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");
                }
                else
                {
                    string monsterName = action;
                    int monsterAttack = int.Parse(splitCommand[1]);

                    heroHealth -= monsterAttack;

                    if (heroHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {heroCoins}");
            Console.WriteLine($"Health: {heroHealth}");
        }
    }
}
