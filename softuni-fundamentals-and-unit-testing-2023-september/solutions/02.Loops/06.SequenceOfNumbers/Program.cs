namespace _06.SequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= maxNumber)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
