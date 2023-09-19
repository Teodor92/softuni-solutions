namespace _02.NumbersFromOneToNReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i += 1)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = number; i >= 1; --i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
