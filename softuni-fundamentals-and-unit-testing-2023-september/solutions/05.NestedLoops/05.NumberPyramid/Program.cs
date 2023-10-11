namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int row = 1; true; row += 1)
            {
                for (int col = 1; col <= row; col += 1)
                {
                    Console.Write($"{counter} ");
                    counter += 1;

                    if (counter > n)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (counter > n)
                {
                    break;
                }
            }
        }
    }
}
