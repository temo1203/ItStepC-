namespace Movie
{
    public class Film : IMovieInterface
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double IMDbRating { get; set; }
        public List<Film> FilmList { get; set; }


        public Film() => FilmList = new List<Film>
            {
                new Film { Name = "The Shawshank Redemption", ReleaseDate = new DateTime(1994, 10, 14), IMDbRating = 9.3 },
                new Film { Name = "The Godfather", ReleaseDate = new DateTime(1972, 3, 24), IMDbRating = 9.2 },
                new Film { Name = "The Dark Knight", ReleaseDate = new DateTime(2008, 7, 18), IMDbRating = 9.0 },
                new Film { Name = "Pulp Fiction", ReleaseDate = new DateTime(1994, 10, 14), IMDbRating = 8.9 },
                new Film { Name = "Schindler's List", ReleaseDate = new DateTime(1993, 12, 15), IMDbRating = 8.9 },
                new Film { Name = "The Lord of the Rings: The Return of the King", ReleaseDate = new DateTime(2003, 12, 17), IMDbRating = 8.9 },
                new Film { Name = "Forrest Gump", ReleaseDate = new DateTime(1994, 7, 6), IMDbRating = 8.8 },
                new Film { Name = "Inception", ReleaseDate = new DateTime(2010, 7, 16), IMDbRating = 8.8 },
                new Film { Name = "Fight Club", ReleaseDate = new DateTime(1999, 10, 15), IMDbRating = 8.8 },
                new Film { Name = "The Matrix", ReleaseDate = new DateTime(1999, 3, 31), IMDbRating = 8.7 }
            };


        //* prints Film List
        public void PrintFilmList()
        {
            foreach (var item in FilmList)
            {
                System.Console.WriteLine($"Name: {item.Name}--IMDB: {item.IMDbRating}--ReleaseDate: {item.ReleaseDate}");
            }
        }

        //* Searches for movies
        public void SearchMovieList(string filmName)
        {
            if (filmName != null && FilmList.Exists(film => film.Name == filmName))
            {
                Console.WriteLine($"You have selected: {filmName}");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid movie from the list.");
            }
        }

        public void AddMovieList(string name, DateTime releaseDate, double imdbRating)
        {
            Film newFilm = new Film { Name = name, ReleaseDate = releaseDate, IMDbRating = imdbRating };
            FilmList.Add(newFilm);
        }
    }
}