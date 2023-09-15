namespace _05.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < maxNumber)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
