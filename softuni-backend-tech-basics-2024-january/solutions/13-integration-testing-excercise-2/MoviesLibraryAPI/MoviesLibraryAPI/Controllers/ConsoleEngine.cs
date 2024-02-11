using MoviesLibraryAPI.Controllers.Contracts;
using MoviesLibraryAPI.Data.Models;
using ZstdSharp.Unsafe;

namespace LibroConsoleAPI.Business
{
    public class ConsoleEngine : IConsoleEngine
    {
        private IMoviesLibraryController _controller;
        public ConsoleEngine(IMoviesLibraryController controller)
        {
            _controller = controller;
        }

        public async Task Run()
        {
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine($"{Environment.NewLine}Choose an option:");
                Console.WriteLine("1: Add Movie");
                Console.WriteLine("2: Delete Movie");
                Console.WriteLine("3: List Movie Catalogue");
                Console.WriteLine("4: Update Movie Info");
                Console.WriteLine("5: Find Movie");
                Console.WriteLine("X: Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddMovie(_controller);
                        break;
                    case "2":
                        await DeleteMovie(_controller);
                        break;
                    case "3":
                        await ViewCatalogue(_controller);
                        break;
                    case "4":
                        await UpdateMovie(_controller);
                        break;
                    case "5":
                        await FindMovie(_controller);
                        break;
                    case "X":
                    case "x":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                static async Task AddMovie(IMoviesLibraryController controller)
                {
                    Console.WriteLine("Adding a new movie:");

                    Console.Write("Enter Title: ");
                    var title = Console.ReadLine();

                    Console.Write("Enter Director: ");
                    var director = Console.ReadLine();

                    Console.Write("Enter Release Year (e.g., 2021): ");
                    if (!int.TryParse(Console.ReadLine(), out int yearReleased))
                    {
                        Console.WriteLine("Invalid year format.");
                        return;
                    }                                       

                    Console.Write("Enter Genre: ");
                    var genre = Console.ReadLine();

                    Console.Write("Enter Movie duration: ");
                    if (!int.TryParse(Console.ReadLine(), out int duration))
                    {
                        Console.WriteLine("Invalid duration format.");
                        return;
                    }

                    Console.Write("Enter Rating: ");
                    if (!double.TryParse(Console.ReadLine(), out double rating))
                    {
                        Console.WriteLine("Invalid Rating format.");
                        return;
                    }

                    var newMovie = new Movie
                    {
                        Title = title,
                        Director = director,
                        YearReleased = yearReleased,
                        Genre = genre,
                        Duration = duration,
                        Rating = rating
                    };

                    await controller.AddAsync(newMovie);
                    Console.WriteLine("Movie added successfully.");
                }

                static async Task DeleteMovie(IMoviesLibraryController controller)
                {
                    Console.Write("Enter complete Title of the movie to delete: ");
                    string title = Console.ReadLine();

                    var movie = await controller.GetByTitle(title);

                    if (movie == null)
                    {
                        Console.WriteLine($"Movie with title {title} not found.");
                        return;
                    }

                    await controller.DeleteAsync(title);
                    Console.WriteLine("Movie deleted successfully.");
                }

                static async Task ViewCatalogue(IMoviesLibraryController controller)
                {
                    var movies = await controller.GetAllAsync();
                    if (movies.Any())
                    {
                        foreach (var movie in movies)
                        {
                            Console.WriteLine($"Movie: {movie.Title}, Rating: {movie.Rating:F1}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No movies available.");
                    }
                }

                static async Task UpdateMovie(IMoviesLibraryController controller)
                {
                    Console.Write("Enter Title of the movie to update: ");
                    string title = Console.ReadLine();
                    var movieToUpdate = await controller.GetByTitle(title);
                    if (movieToUpdate == null)
                    {
                        Console.WriteLine("Movie not found.");
                        return;
                    }

                    Console.Write("Enter new Title (leave blank to keep current): ");
                    var newTitle = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTitle))
                    {
                        movieToUpdate.Title = newTitle;
                    }

                    Console.Write("Enter new Director (leave blank to keep current): ");
                    var director = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(director))
                    {
                        movieToUpdate.Director = director;
                    }

                    Console.Write("Enter new Year Released value (leave blank to keep current): ");
                    var year = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(year))
                    {
                        movieToUpdate.YearReleased = int.Parse(year);
                    }

                    Console.Write("Enter new Genre (leave blank to keep current): ");
                    var genre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(genre))
                    {
                        movieToUpdate.Genre = genre;
                    }

                    Console.Write("Enter new Duration value (leave blank to keep current): ");
                    var duration = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(duration))
                    {
                        movieToUpdate.Duration = int.Parse(duration);
                    }

                    Console.Write("Enter new Rating value (leave blank to keep current): ");
                    var rating = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(rating))
                    {
                        movieToUpdate.Rating = double.Parse(rating);
                    }

                    await controller.UpdateAsync(movieToUpdate);
                    Console.WriteLine("Movie updated successfully.");
                }

                static async Task FindMovie(IMoviesLibraryController controller)
                {
                    Console.Write("Enter title or part of the title: ");
                    string titleFragment = Console.ReadLine();
                    var movies = await controller.SearchByTitleFragmentAsync(titleFragment);

                    if (movies.Any())
                    {
                        if(movies.Count() == 1)
                        {  
                            var movie = movies.First();
                            Console.WriteLine();
                            Console.WriteLine($"Movie: {movie.Title}, Rating: {movie.Rating:F1}");
                            Console.WriteLine($"Director: {movie.Director}, Release Date: {movie.YearReleased}");
                        }
                        else
                        {
                            foreach (var movie in movies)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Movie: {movie.Title}, Rating: {movie.Rating:F1}");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("No movies found with the given title fragment.");
                    }
                }
            }
        }
    }
}
