namespace Movie
{
    public class LoginRegistrationClass
    {
        public void FistPage()
        {
            int CountOfReset = 0;
            User user = new();
            bool whileBool = true;
            while (whileBool)
            {
                System.Console.WriteLine("Login(1)--Registration(2)--Exit(3)");
                int selectedNum = int.Parse(Console.ReadLine());
                try
                {
                    if (selectedNum == 1)
                    {
                        System.Console.WriteLine("Enter name:");
                        string? EnteredName = Console.ReadLine();
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Enter Password:");
                        string? EnteredPassword = Console.ReadLine();

                        //! Check if a user with the entered name exists
                        foreach (User item in User.UsersList)
                        {
                            if (item.Name == EnteredName && item.Password == EnteredPassword)
                            {
                                //* Perform action for authenticated user
                                Console.WriteLine("Login successful!");
                                HomeMovieClass.MovieSection();
                                // return; // Exit the method after successful login
                            }
                        }
                        if (CountOfReset == 3)
                        {
                            System.Console.WriteLine("Recovering Your Information!!");
                            System.Console.WriteLine("Enter Your Name");
                            string? ResetName = Console.ReadLine();
                            System.Console.WriteLine("");
                            System.Console.WriteLine("Enter Your New Password!!");
                            string? ResetPassword = Console.ReadLine();
                            CountOfReset = 0;
                        }
                        // If no matching user is found
                        CountOfReset++;
                        Console.WriteLine("Invalid username or password. Please try again.");
                    }
                    else if (selectedNum == 2)
                    {
                        Registration.ShowRegistration();
                    }
                    else if (selectedNum == 3)
                    {
                        System.Console.WriteLine("Bye Bye :)");
                        whileBool = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Choose Correct Number");
                    }
                }
                catch (FormatException ex)
                {
                    throw new FormatException("Input was not a valid number. Please enter a valid number.", ex);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

        }
    }
}
