using LibroConsoleAPI.Business;
using Microsoft.Extensions.Configuration;
using MoviesLibraryAPI.Controllers;
using MoviesLibraryAPI.Data;
using MoviesLibraryAPI.Data.Seed;
using MoviesLibraryAPI.Services;

namespace MoviesLibraryAPI
{
    public class StartUp
    {
        public static async Task Main(string[] args)
        {
            // Set up Configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Initialize MoviesLibraryDbContext with configuration
            var dbContext = new MoviesLibraryDbContext(configuration);
            var dbSeeder = new DbSeeder(dbContext.Movies);

            // Clear the database
            await dbContext.ClearDatabaseAsync();
            await dbSeeder.SeedDatabaseAsync();

            // Create instances of the repository, controller, and console engine
            var moviesRepository = new MoviesRepository(dbContext.Movies);
            var moviesLibraryController = new MoviesLibraryController(moviesRepository);
            var engine = new ConsoleEngine(moviesLibraryController);

            // Start the Console Engine
            await engine.Run();
        }
    }
}