using MongoDB.Driver;
using MoviesLibraryAPI.Data.Models;
using Newtonsoft.Json;

namespace MoviesLibraryAPI.Data.Seed
{
    public class DbSeeder
    {
        private readonly IMongoCollection<Movie> _mongoCollection;

        public DbSeeder(IMongoCollection<Movie> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public async Task SeedDatabaseAsync()
        {
            // Check if the collection is empty before seeding
            var existingCount = await _mongoCollection.CountDocumentsAsync(_ => true);
            if (existingCount > 0)
            {
                return; // Database is already seeded
            }

            // Read the JSON file and deserialize it to a list of Movie objects
            var moviesData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(),"Data/Seed", "movies.json"));
            var movies = JsonConvert.DeserializeObject<List<Movie>>(moviesData);

            // Insert movies into the database
            if (movies != null && movies.Count > 0)
            {
                await _mongoCollection.InsertManyAsync(movies);
            }
        }
    }
}
