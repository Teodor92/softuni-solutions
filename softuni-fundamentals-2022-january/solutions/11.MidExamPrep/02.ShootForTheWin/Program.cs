using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int shotTargets = 0;
            var command = Console.ReadLine();

            while (command != "End")
            {
                var targetIndex = int.Parse(command);

                if (targetIndex >= 0 && targetIndex < targets.Length && targets[targetIndex] != -1)
                {
                    shotTargets++;
                    ShootTarget(targets, targetIndex);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }

        static void ShootTarget(int[] targets, int indexToShoot)
        {
            var valueToShoot = targets[indexToShoot];
            targets[indexToShoot] = -1;

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] != -1)
                {
                    if (targets[i] > valueToShoot)
                    {
                        targets[i] -= valueToShoot;
                    }
                    else
                    {
                        targets[i] += valueToShoot;
                    }
                }
            }
        }
    }
}
