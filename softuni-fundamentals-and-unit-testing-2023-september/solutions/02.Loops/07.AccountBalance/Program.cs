namespace _07.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalAmount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "NoMoreMoney")
                {
                    break;
                }

                double amount = double.Parse(command);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalAmount += amount;
                Console.WriteLine($"Increase: {amount:F2}");
            }

            Console.WriteLine($"Total: {totalAmount:F2}");
        }
    }
}
