using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double cost = double.Parse(Console.ReadLine());
                double totalSavings = 0;

                while (cost > totalSavings)
                {
                    double saving = double.Parse(Console.ReadLine());
                    totalSavings += saving;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
