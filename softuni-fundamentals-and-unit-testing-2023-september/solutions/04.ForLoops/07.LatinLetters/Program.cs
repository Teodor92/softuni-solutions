namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());

            for (char i = startLetter; i <= endLetter; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
