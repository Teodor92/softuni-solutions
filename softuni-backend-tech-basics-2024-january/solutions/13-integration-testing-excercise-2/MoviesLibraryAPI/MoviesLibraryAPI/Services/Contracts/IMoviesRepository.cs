using MoviesLibraryAPI.Data.Models;

namespace MoviesLibraryAPI.Services.Contracts
{
    public interface IMoviesRepository
    {
        Task AddMovieAsync(Movie movie);
        Task DeleteMovieAsync(string id);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetSpecificMovieAsync(string title);
        Task<IEnumerable<Movie>> GetMoviesByTitleAsync(string titleFragment);
        Task UpdateMovieAsync(Movie movie);
    }
}
