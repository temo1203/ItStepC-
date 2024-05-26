namespace Movie
{
    public class HomeMovieClass
    {
        public static void MovieSection()
        {
            bool isBool = true;

            List<Film> films = new List<Film>
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

            Console.WriteLine("Welcome to AdjaraNet.com");
            Console.WriteLine("How can we help you?");
            System.Console.WriteLine("");
            while (isBool)
            {
                Console.WriteLine("Search Movie(1)\nPrint Movie(2)\nAdd Movie(3)\nRemove movie(4)\nEdit movie(5)\n------------------\nMember registration(6)\nPrint member(7)\nRemove member(8)\nSearch member(9)\nLogin(10)");
                var num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        System.Console.WriteLine("Welcome to Movie Section Choose Your Movie");
                        foreach (Film film in films)
                        {
                            Console.WriteLine(film.Name);
                        }
                        var selectedFilm = Console.ReadLine();
                        if (selectedFilm != null && films.Exists(film => film.Name == selectedFilm))
                        {
                            Console.WriteLine($"You have selected: {selectedFilm}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Please choose a valid movie from the list.");
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("Add Your Movie");
                        var addedMovie = Console.ReadLine();
                        if (addedMovie != null)
                        {
                            films.Add(new Film(addedMovie, DateTime.Now, 0.0)); // it add new film to this section
                        }
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Registration.ShowRegistration();
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }
    }
    public class Film
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double IMDbRating { get; set; }

        public Film(string name, DateTime releaseDate, double imdbRating)
        {
            Name = name;
            ReleaseDate = releaseDate;
            IMDbRating = imdbRating;
        }
    }
}
