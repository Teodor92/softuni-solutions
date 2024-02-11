using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MoviesLibraryAPI.Data.Models;

namespace MoviesLibraryAPI.Data
{
    public class MoviesLibraryDbContext
    {
        private readonly IMongoDatabase _database;

        public MoviesLibraryDbContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MoviesLibraryDb");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("MoviesLibrary");
        }
        public IMongoCollection<Movie> Movies => _database.GetCollection<Movie>("Movies");

        public async Task ClearDatabaseAsync()
        {
            await _database.DropCollectionAsync("Movies");
        }
    }
}
