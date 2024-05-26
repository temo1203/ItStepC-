namespace Movie
{
    public class Film : IMovieInterface
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double IMDbRating { get; set; }
        public List<Film> FilmList { get; set; }

        public Film(string name, DateTime releaseDate, double imdbRating)
        {
            Name = name;
            ReleaseDate = releaseDate;
            IMDbRating = imdbRating;
        }

        public Film()
        {
            FilmList = new List<Film>
            {
                new Film("The Shawshank Redemption", new DateTime(1994, 10, 14), 9.3),
                new Film("The Godfather", new DateTime(1972, 3, 24), 9.2),
                new Film("The Dark Knight", new DateTime(2008, 7, 18), 9.0),
                new Film("Pulp Fiction", new DateTime(1994, 10, 14), 8.9),
                new Film("Schindler's List", new DateTime(1993, 12, 15), 8.9),
                new Film("The Lord of the Rings: The Return of the King", new DateTime(2003, 12, 17), 8.9),
                new Film("Forrest Gump", new DateTime(1994, 7, 6), 8.8),
                new Film("Inception", new DateTime(2010, 7, 16), 8.8),
                new Film("Fight Club", new DateTime(1999, 10, 15), 8.8),
                new Film("The Matrix", new DateTime(1999, 3, 31), 8.7)
            };
        }

        public void PrintFilmList()
        {
            foreach (var item in FilmList)
            {
                System.Console.WriteLine($"Name: {item.Name}--IMDB: {item.IMDbRating}--ReleaseDate: {item.ReleaseDate}");
            }
        }
    }
}