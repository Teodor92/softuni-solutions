namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= endNumber; i += 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
