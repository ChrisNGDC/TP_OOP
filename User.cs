namespace TP_OOP
{
    internal class User
    {
        string Username;
        string Password;
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool CorrectData(string username, string password) { return Username == username && Password == password; }
    }
}
