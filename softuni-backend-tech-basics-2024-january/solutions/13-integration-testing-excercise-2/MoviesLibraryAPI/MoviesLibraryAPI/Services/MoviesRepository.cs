using MongoDB.Driver;
using MoviesLibraryAPI.Data.Models;
using MoviesLibraryAPI.Services.Contracts;

namespace MoviesLibraryAPI.Services
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly IMongoCollection<Movie> _moviesCollection;

        public MoviesRepository(IMongoCollection<Movie> moviesCollection)
        {
            _moviesCollection = moviesCollection;
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _moviesCollection.InsertOneAsync(movie);
        }

        public Task DeleteMovieAsync(string id)
        {
            var filter = Builders<Movie>.Filter.Eq(m => m.Id, id);
            return _moviesCollection.DeleteOneAsync(filter);
        }

        public async Task<Movie> GetSpecificMovieAsync(string title)
        {
            var filter = Builders<Movie>.Filter.Eq(m => m.Title, title);
            return await _moviesCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesByTitleAsync(string titleFragment)
        {
            var filter = Builders<Movie>.Filter.Regex(m => m.Title, new MongoDB.Bson.BsonRegularExpression(titleFragment, "i"));
            return await _moviesCollection.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _moviesCollection.Find(_ => true).ToListAsync();
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie), "Movie cannot be null.");
            }

            var filter = Builders<Movie>.Filter.Eq(m => m.Id, movie.Id);
            await _moviesCollection.ReplaceOneAsync(filter, movie, new ReplaceOptions { IsUpsert = false });
        }
    }
}
