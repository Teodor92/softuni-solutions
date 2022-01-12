using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("TEST!");
            //Console.WriteLine();
            //Console.Write("TEST2!");

            int florsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int floor = florsCount; floor >= 1; floor--)
            {
                for (int room = 0; room < roomsCount; room++)
                {
                    if (floor == florsCount)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
