namespace _07.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                int sum = 0;
                int inputNum = int.Parse(input);

                for (int num = inputNum; num > 0; num = num / 10)
                {
                    sum += num % 10;
                }

                Console.WriteLine($"Sum of digits = {sum}");
            }

            Console.WriteLine("Goodbye");
        }
    }
}
