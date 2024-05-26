namespace Movie
{
    public class Registration
    {

        public static void ShowRegistration()
        {
            IUserInterface userInterface = new User();
            System.Console.WriteLine("Name: ");
            string? name = Console.ReadLine();
            System.Console.WriteLine("Username: ");
            string? username = Console.ReadLine();
            System.Console.WriteLine("Password: ");
            string? password = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string? email = Console.ReadLine();
            System.Console.WriteLine("Registration successful :)");


            if (name != null && username != null && password != null && email != null)
            {
                System.Console.WriteLine("Registration successful :)");
                System.Console.WriteLine($"{name}=={username}=={password}=={email}");

                // userInterface object where we insert things
                userInterface.UserAboutInfo(name, username, password, email);
            }
            else
            {

                System.Console.WriteLine("Registration failed. Please provide all required information.");
            }
        }
    }
}
