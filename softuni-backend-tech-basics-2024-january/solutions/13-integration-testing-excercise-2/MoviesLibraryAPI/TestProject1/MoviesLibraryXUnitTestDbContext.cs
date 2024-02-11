using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MoviesLibraryAPI.Data.Models;

public class MoviesLibraryXUnitTestDbContext
{
    private readonly IMongoDatabase _database;
    private readonly MongoClient _client;

    public MoviesLibraryXUnitTestDbContext(IConfiguration configuration, string dbName)
    {
        var connectionString = configuration.GetConnectionString("MoviesLibraryDbXUnit");
        _client = new MongoClient(connectionString);
        _database = _client.GetDatabase(dbName);
    }

    public IMongoCollection<Movie> Movies => _database.GetCollection<Movie>("Movies");

    public async Task ClearDatabaseAsync()
    {
        await _client.DropDatabaseAsync(_database.DatabaseNamespace.DatabaseName);
    }
}
