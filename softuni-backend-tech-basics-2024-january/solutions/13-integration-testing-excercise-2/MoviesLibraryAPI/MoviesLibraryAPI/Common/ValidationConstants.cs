namespace MoviesLibraryAPI.Common
{
    public static class ValidationConstants
    {
        public const int MovieTitleMaxLength = 100;
        public const int MovieDirectorMaxLength = 100;
        public const int YearReleasedMin = 1900;
        public const int YearReleasedMax = 2030;
        public const int MovieGenreMaxLength = 100;
        public const int MovieDurationMin = 1;
        public const int MovieDurationMax = 500;
        public const double MovieRatingMin = 0.0;
        public const double MovieRatingMax = 10.0; // Assuming a rating scale of 0-10
    }

}
