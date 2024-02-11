using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MoviesLibraryAPI.Common;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibraryAPI.Data.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.MovieTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.MovieDirectorMaxLength)]
        public string Director { get; set; } = null!;

        [Range(ValidationConstants.YearReleasedMin, ValidationConstants.YearReleasedMax)]
        public int YearReleased { get; set; }

        [Required]
        [StringLength(ValidationConstants.MovieGenreMaxLength)]
        public string Genre { get; set; } = null!;

        [Range(ValidationConstants.MovieDurationMin, ValidationConstants.MovieDurationMax)]
        public int Duration { get; set; }

        [Range(ValidationConstants.MovieRatingMin, ValidationConstants.MovieRatingMax)]
        public double Rating { get; set; }
    }
}
