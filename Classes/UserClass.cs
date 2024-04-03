using FIZIKEND.Windows;

namespace FIZIKEND.Classes
{
    public class User
    {

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {
            Login = string.Empty;
            Password = string.Empty;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
