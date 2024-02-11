using Microsoft.Extensions.Configuration;

namespace MoviesLibraryAPI.XUnitTests
{
    public class DatabaseFixture : IDisposable
    {
        public MoviesLibraryXUnitTestDbContext DbContext { get; private set; }

        public DatabaseFixture()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string dbName = $"MoviesLibraryTestDb_{Guid.NewGuid()}";
            DbContext = new MoviesLibraryXUnitTestDbContext(configuration, dbName);
        }

        public void Dispose()
        {
            DbContext.ClearDatabaseAsync().Wait();
        }
    }
}
