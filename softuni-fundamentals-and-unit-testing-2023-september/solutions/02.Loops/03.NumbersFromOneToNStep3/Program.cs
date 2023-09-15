namespace _03.NumbersFromOneToNStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endNumber; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
