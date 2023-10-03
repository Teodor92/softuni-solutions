namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                if (i == end)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
