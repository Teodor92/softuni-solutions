using System;
using TownsApplication.Data.Models;

namespace TownsApplication
{
    public class Program
    {
        static void Main()
        {
            TownController controller = new TownController();
            Console.WriteLine("Welcome to the Town Management System!");
            Console.WriteLine("======================================");

            while (true)
            {
                Console.WriteLine($"{Environment.NewLine}Choose an action:");
                Console.WriteLine("1. Add a Town");
                Console.WriteLine("2. Update a Town's Population");
                Console.WriteLine("3. Delete a Town");
                Console.WriteLine("4. List All Towns");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Town Name: ");
                        string townName = Console.ReadLine();
                        Console.Write("Enter Population: ");
                        if (int.TryParse(Console.ReadLine(), out int population))
                        {
                            try
                            {
                                controller.AddTown(townName, population);
                                Console.WriteLine($"Town '{townName}' added successfully!");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid population format. Please enter a valid number.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Town ID to Update: ");
                        if (int.TryParse(Console.ReadLine(), out int townId))
                        {
                            Console.Write("Enter New Population: ");
                            if (int.TryParse(Console.ReadLine(), out int newPopulation))
                            {
                                try
                                {
                                    controller.UpdateTown(townId, newPopulation);
                                    Console.WriteLine("Population updated successfully!");
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid population format. Please enter a valid number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID format. Please enter a valid number.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter Town ID to Delete: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteId))
                        {
                            try
                            {
                                controller.DeleteTown(deleteId);
                                Console.WriteLine("Town deleted successfully!");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID format. Please enter a valid number.");
                        }
                        break;

                    case "4":
                        var towns = controller.ListTowns();
                        Console.WriteLine($"{Environment.NewLine}List of Towns:");
                        foreach (var town in towns)
                        {
                            Console.WriteLine($"ID: {town.Id}, Name: {town.Name}, Population: {town.Population}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Thank you for using the Town Management System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                        break;
                }
            }
        }
    }
}
