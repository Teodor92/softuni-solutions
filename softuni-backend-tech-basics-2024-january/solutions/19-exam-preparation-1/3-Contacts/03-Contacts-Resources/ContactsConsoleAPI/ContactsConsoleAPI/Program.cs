using ContactsConsoleAPI.Business;
using ContactsConsoleAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace ContactsConsoleAPI
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {

                var engine = new Engine();

                var contextFactory = new ContactDbContextFactory();

                using var context = contextFactory.CreateDbContext(args);

                await context.Database.MigrateAsync();

                var contactRepository = new ContactRepository(context);
                var contactManager = new ContactManager(contactRepository);


                await DatabaseSeeder.SeedDatabaseAsync(context, contactManager);

                await engine.Run(contactManager);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }
    }
}
