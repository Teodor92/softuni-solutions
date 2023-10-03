namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numberOfNumbers; i += 1)
            {
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }

            Console.WriteLine(sum);
        }
    }
}
