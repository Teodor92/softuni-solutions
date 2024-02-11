using MoviesLibraryAPI.Controllers.Contracts;
using MoviesLibraryAPI.Data.Models;
using MoviesLibraryAPI.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibraryAPI.Controllers
{
    public class MoviesLibraryController : IMoviesLibraryController
    {
        private IMoviesRepository _moviesRepository;

        public MoviesLibraryController(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        public async Task AddAsync(Movie movie)
        {
            if (!IsValid(movie))
            {
                throw new ValidationException("Movie is not valid.");
            }
            await _moviesRepository.AddMovieAsync(movie);
        }

        public async Task DeleteAsync(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }

            var movieToDelete = await _moviesRepository.GetSpecificMovieAsync(title);
            if (movieToDelete != null)
            {
                _moviesRepository.DeleteMovieAsync(movieToDelete.Id);
            }
            else
            {
                throw new InvalidOperationException($"Movie with title '{title}' not found.");
            }            
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _moviesRepository.GetAllMoviesAsync();
        }

        public async Task<Movie> GetByTitle(string title)
        {
            var movie = await _moviesRepository.GetSpecificMovieAsync(title);
            return movie;
        }

        public async Task<IEnumerable<Movie>> SearchByTitleFragmentAsync(string titleFragment)
        {
            var movies = await _moviesRepository.GetMoviesByTitleAsync(titleFragment);

            if (!movies.Any())
            {
                throw new KeyNotFoundException("No movies found.");
            }

            return movies;
        }

        public async Task UpdateAsync(Movie movie)
        {
            if (!IsValid(movie))
            {
                throw new ValidationException("Movie is not valid.");
            }

            await _moviesRepository.UpdateMovieAsync(movie);
        }

        private bool IsValid(Movie movie)
        {
            if (movie == null)
            {
                Console.WriteLine("Validation Error: Movie is null.");
                return false;
            }

            var validateResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(movie);

            if (!Validator.TryValidateObject(movie, validationContext, validateResults, true))
            {
                foreach (var validationResult in validateResults)
                {
                    Console.WriteLine($"Validation Error: {validationResult.ErrorMessage}");
                }
                return false;
            }

            return true;
        }
    }
}
