using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * length * height;
            bool hasRoomLeft = true;

            // 12312 | "Done"
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxCount = int.Parse(input);

                freeSpace = freeSpace - boxCount * 1;

                if (freeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    hasRoomLeft = false;
                    break;
                }

                input = Console.ReadLine();
            }

            if (hasRoomLeft)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
