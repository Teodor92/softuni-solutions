using Microsoft.EntityFrameworkCore;
using ProductConsoleAPI.Business;
using ProductConsoleAPI.DataAccess;

namespace ProductConsoleAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {

                var engine = new Engine();

                var contextFactory = new ProductsDbContextFactory();

                using var context = contextFactory.CreateDbContext(args);

                await context.Database.MigrateAsync();

                var productsRepository = new ProductsRepository(context);
                var productsManager = new ProductsManager(productsRepository);


                await DatabaseSeeder.SeedDatabaseAsync(context, productsManager);

                await engine.Run(productsManager);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }
    }
}
