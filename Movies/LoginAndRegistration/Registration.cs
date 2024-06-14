namespace Movie
{
    public class Registration
    {

        public static void ShowRegistration()
        {
            IUserInterface userInterface = new User();
            System.Console.WriteLine("Enter Name: ");
            string? name = Console.ReadLine();
            System.Console.WriteLine("Enter Username: ");
            string? username = Console.ReadLine();
            System.Console.WriteLine("Enter Password: ");
            string? password = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string? email = Console.ReadLine();



            if (name != null && username != null && password != null && email != null)
            {
                System.Console.WriteLine("Registration successful :)");



                userInterface.UserAboutInfo(name, username, password, email);
            }
            else
            {

                System.Console.WriteLine("Registration failed. Please provide all required information.");
            }
        }
    }
}
