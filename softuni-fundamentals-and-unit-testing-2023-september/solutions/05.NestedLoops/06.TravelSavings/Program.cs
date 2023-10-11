namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double collectedSum = 0;
                while (collectedSum < neededSum)
                {
                    double sumToBeAdded = double.Parse(Console.ReadLine());
                    collectedSum += sumToBeAdded;
                    Console.WriteLine($"Collected: {collectedSum:F2}");
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
