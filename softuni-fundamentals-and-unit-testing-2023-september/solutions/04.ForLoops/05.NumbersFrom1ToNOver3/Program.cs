namespace _05.NumbersFrom1ToNOver3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endOfRange; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
