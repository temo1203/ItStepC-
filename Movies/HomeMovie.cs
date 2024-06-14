namespace Movie
{
    public class HomeMovieClass
    {
        public static void MovieSection()
        {
            bool isBool = true;
            IUserInterface userInterface = new User();
            IMovieInterface movieInterface = new Film();
            Console.WriteLine("Welcome to AdjaraNet.com");
            Console.WriteLine("How can we help you?");
            System.Console.WriteLine("");
            while (isBool)
            {
                Console.WriteLine("Search Movie(1)\nAdd Movie(2)\nPrint Movie(3)\nRemove movie(4)\nShow Selected Movies(5)\n------------------\nMember registration(6)\nPrint member(7)\nRemove member(8)\nSearch member(9)\nLogin(10)");
                var num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        System.Console.WriteLine("Welcome to Movie Section Choose Your Movie");
                        var selectedFilm = Console.ReadLine();
                        if (selectedFilm != null)
                        {
                            movieInterface.SearchMovieList(selectedFilm);
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("Add Your Movie :)");
                        var addedMovie = Console.ReadLine();
                        System.Console.WriteLine("Enter IMDB");
                        double movieIMDB = int.Parse(Console.ReadLine());
                        if (addedMovie != null)
                        {
                            movieInterface.AddMovieList(addedMovie, DateTime.Now, movieIMDB);
                            Console.WriteLine($"Movie '{addedMovie}' added successfully.");
                        }
                        else
                        {
                            System.Console.WriteLine("Somethings Wrong try again");
                        }
                        break;
                    case 3:
                        movieInterface.PrintFilmList();
                        break;
                    case 4:
                        System.Console.WriteLine("Enter Removed Movie Id");
                        int addedId = int.Parse(Console.ReadLine());
                        movieInterface.RemoveFilmById(addedId);
                        break;
                    case 5:
                        movieInterface.SelectedFilms();
                        break;
                    case 6:
                        Registration.ShowRegistration();
                        break;
                    case 7:
                        userInterface.PrintUserList();
                        break;
                    case 8:
                        // Functionality for removing a member
                        break;
                    case 9:
                        // Functionality for searching a member
                        break;
                    case 10:
                        // Functionality for login
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                        break;
                }
            }
        }
    }
}
