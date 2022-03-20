using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        public class Hero
        {
            public Hero(string name, int hp, int mp)
            {
                this.Name = name;
                this.HitPoints = hp;
                this.ManaPoints = mp;
            }

            public string Name { get; set; }

            public int HitPoints { get; set; }

            public int ManaPoints { get; set; }
        }

        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputTokens[0];
                int hp = int.Parse(inputTokens[1]);
                int mp = int.Parse(inputTokens[2]);

                heroes.Add(new Hero(name, hp, mp));
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command.Split(" - ").ToArray();

                if (commandArgs[0] == "CastSpell")
                {
                    string heroName = commandArgs[1];
                    int manaNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    Hero hero = heroes.FirstOrDefault(x => x.Name == heroName);

                    if (hero.ManaPoints >= manaNeeded)
                    {
                        hero.ManaPoints -= manaNeeded;
                        Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandArgs[0] == "TakeDamage")
                {
                    string defenderName = commandArgs[1];
                    int damage = int.Parse(commandArgs[2]);
                    string attackerName = commandArgs[3];

                    Hero defender = heroes.FirstOrDefault(x => x.Name == defenderName);

                    defender.HitPoints -= damage;

                    if (defender.HitPoints > 0)
                    {
                        Console.WriteLine($"{defender.Name} was hit for {damage} HP by {attackerName} and now has {defender.HitPoints} HP left!");
                    }
                    else
                    {
                        heroes.Remove(defender);
                        Console.WriteLine($"{defenderName} has been killed by {attackerName}!");
                    }
                }
                else if (commandArgs[0] == "Recharge")
                {
                    string heroName = commandArgs[1];
                    int mana = int.Parse(commandArgs[2]);

                    Hero hero = heroes.FirstOrDefault(x => x.Name == heroName);

                    int recharged = hero.ManaPoints + mana >= 200 ? 200 - hero.ManaPoints : mana;

                    Console.WriteLine($"{hero.Name} recharged for {recharged} MP!");
                    hero.ManaPoints += recharged;
                }
                else if (commandArgs[0] == "Heal")
                {
                    string heroName = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);

                    Hero hero = heroes.FirstOrDefault(x => x.Name == heroName);

                    int recharged = hero.HitPoints + health >= 100 ? 100 - hero.HitPoints : health;

                    Console.WriteLine($"{hero.Name} healed for {recharged} HP!");
                    hero.HitPoints += recharged;
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }
}
