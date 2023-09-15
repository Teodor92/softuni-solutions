namespace _01.NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
