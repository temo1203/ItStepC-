namespace Movie
{
    public class HomeMovieClass
    {
        public static void MovieSection()
        {
            bool isBool = true;
            IUserInterface userInterface = new User();
            IMovieInterface movieInterface = new Film();
            Film films = new();
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
                        foreach (Film film in films.FilmList)
                        {
                            Console.WriteLine(film.Name);
                        }
                        var selectedFilm = Console.ReadLine();
                        if (selectedFilm != null && films.FilmList.Exists(film => film.Name == selectedFilm))
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
                            films.FilmList.Add(new Film(addedMovie, DateTime.Now, 0.0)); // it add new film to this section
                        }
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        userInterface.PrintUserList();
                        break;
                    case 6:
                        Registration.ShowRegistration();
                        break;
                    case 7:
                        movieInterface.PrintFilmList();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }
    }

}
