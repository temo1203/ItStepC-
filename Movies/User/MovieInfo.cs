using System;
using System.Collections.Generic;

namespace Movie
{
    public class Film : IMovieInterface
    {
        public int Id { get; set; } // Unique ID for each film
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double IMDbRating { get; set; }
        public List<Film> FilmList { get; set; }

        private static List<Film> GetPredefinedFilms()
        {
            return new List<Film>
            {
                new Film(1, "The Shawshank Redemption", new DateTime(1994, 10, 14), 9.3),
                new Film(2, "The Godfather", new DateTime(1972, 3, 24), 9.2),
                new Film(3, "The Dark Knight", new DateTime(2008, 7, 18), 9.0),
                new Film(4, "Pulp Fiction", new DateTime(1994, 10, 14), 8.9),
                new Film(5, "Schindler's List", new DateTime(1993, 12, 15), 8.9),
                new Film(6, "The Lord of the Rings: The Return of the King", new DateTime(2003, 12, 17), 8.9),
                new Film(7, "Forrest Gump", new DateTime(1994, 7, 6), 8.8),
                new Film(8, "Inception", new DateTime(2010, 7, 16), 8.8),
                new Film(9, "Fight Club", new DateTime(1999, 10, 15), 8.8),
                new Film(10, "The Matrix", new DateTime(1999, 3, 31), 8.7)
            };
        }

        // Default constructor initializes FilmList with predefined films
        public Film()
        {
            FilmList = GetPredefinedFilms();
        }

        // Constructor to create individual Film objects with an ID
        public Film(int id, string name, DateTime releaseDate, double imdbRating)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            IMDbRating = imdbRating;
        }

        public void PrintFilmList()
        {
            foreach (var item in FilmList)
            {
                Console.WriteLine($"ID: {item.Id} -- Name: {item.Name} -- IMDB: {item.IMDbRating} -- ReleaseDate: {item.ReleaseDate}");
            }
        }

        public void SearchMovieList(string filmName)
        {
            var film = FilmList.Find(f => f.Name.Equals(filmName, StringComparison.OrdinalIgnoreCase));
            if (film != null)
            {
                Console.WriteLine($"You have selected: {film.Name}");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid movie from the list.");
            }
        }

        public void AddMovieList(string name, DateTime releaseDate, double imdbRating)
        {
            int newId = FilmList.Count > 0 ? FilmList[FilmList.Count - 1].Id + 1 : 1;
            Film newFilm = new Film(newId, name, releaseDate, imdbRating);
            FilmList.Add(newFilm);
        }


        public void RemoveFilmById(int id)
        {
            int index = FilmList.FindIndex(f => f.Id == id);
            Console.WriteLine($"Attempting to remove film with ID {id}...");
            if (index != -1)
            {
                FilmList.RemoveAt(index);
                Console.WriteLine($"Film with ID {id} has been removed.");
            }
            else
            {
                Console.WriteLine($"Film with ID {id} not found.");
            }
            Console.WriteLine("Current Film List after removal:");
            PrintFilmList(); // Debugging output
        }

    }
}
