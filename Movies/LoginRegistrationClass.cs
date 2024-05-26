namespace Movie
{
    public class LoginRegistrationClass
    {
        public void FistPage()
        {
            User user = new User();
            bool whileBool = true;
            while (whileBool)
            {
                System.Console.WriteLine("Login(1)--Registration(2)--Exit(3)");
                int selectedNum = Convert.ToInt32(Console.ReadLine());
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

                        // If no matching user is found
                        Console.WriteLine("Invalid username or password. Please try again.");
                    }
                    else if (selectedNum == 2)
                    {
                        Registration.ShowRegistration();
                    }
                    else if (selectedNum == 3)
                    {
                        System.Console.WriteLine("Bye Bye :)");
                        user.PrintUsersList();
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
