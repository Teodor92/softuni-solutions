using ItemManagementLib.Data;
using ItemManagementLib.Models;
using ItemManagementLib.Repositories;
using ItemManagementApp.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace ItemManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the connection string
            string connectionString = "Server=.;Database=ItemManagement;Trusted_Connection=True;";

            // Configure the DbContextOptionsBuilder with the connection string
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            try
            {
                // Instantiate the AppDbContext with the options from the optionsBuilder
                using (var context = new AppDbContext(optionsBuilder.Options))
                {
                    // Ensure the database is created
                    context.Database.EnsureCreated();

                    // Create the repository and service instances
                    var itemRepository = new ItemRepository(context);
                    var itemService = new ItemService(itemRepository); 

                    bool running = true;
                    while (running)
                    {
                        Console.WriteLine("Choose an option:");
                        Console.WriteLine("1. Add item");
                        Console.WriteLine("2. List items");
                        Console.WriteLine("3. Update item");
                        Console.WriteLine("4. Delete item");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter option: ");

                        var option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                Console.Write("Enter item name: ");
                                var name = Console.ReadLine();
                                itemService.AddItem(name);
                                Console.WriteLine("Item added.");
                                break;
                            case "2":
                                var items = itemService.GetAllItems();
                                foreach (var item in items)
                                {
                                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
                                }
                                break;
                            case "3":
                                Console.Write("Enter item ID to update: ");
                                var updateId = int.Parse(Console.ReadLine());
                                Console.Write("Enter new name: ");
                                var newName = Console.ReadLine();
                                itemService.UpdateItem(updateId, newName);
                                Console.WriteLine("Item updated.");
                                break;
                            case "4":
                                Console.Write("Enter item ID to delete: ");
                                var deleteId = int.Parse(Console.ReadLine());
                                itemService.DeleteItem(deleteId);
                                Console.WriteLine("Item deleted.");
                                break;
                            case "5":
                                running = false;
                                break;
                            default:
                                Console.WriteLine("Invalid option, try again.");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // Keep the console open
        }
    }
}

