namespace _07.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;

            while (command != "NoMoreMoney")
            {
                double amount = double.Parse(command);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += amount;
                Console.WriteLine($"Increase: {amount:F2}");
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
