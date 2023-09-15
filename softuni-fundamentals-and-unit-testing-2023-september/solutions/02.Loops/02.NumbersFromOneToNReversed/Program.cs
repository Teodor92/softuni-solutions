namespace _02.NumbersFromOneToNReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = endNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
