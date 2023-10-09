namespace _03.TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
