namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());

            for (int floor = floorCount; floor >= 1; floor -= 1)
            {
                for (int room = 0; room < roomCount; room += 1)
                {
                    if (floor == floorCount)
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
