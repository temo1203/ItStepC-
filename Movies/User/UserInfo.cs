namespace Movie
{
    public class User : IUserInterface
    {

        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public static List<User> UsersList = new List<User>();

        //prints user things
        public void PrintUserList()
        {
            Console.WriteLine("Registered Users:");
            foreach (User user in UsersList)
            {
                Console.WriteLine($"Name: {user.Name}, Username: {user.Username}, Email: {user.Email}");
            }
        }


        //interface of user
        public void UserAboutInfo(string name, string username, string password, string email)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            UsersList.Add(this);
        }
    }

}
