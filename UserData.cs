namespace TP_OOP
{
    internal class UserData
    {
        static UserData? instance;
        List<User> Users;
        public static string? ActualUser { get; set; }
        private UserData()
        {
            Users = new List<User>();
            AddUser("admin", "admin");
            AddUser("Pablo", "Avellaneda");
            AddUser("Chris", "-Gabor-");
        }
        public static UserData GetInstance()
        {
            instance ??= new UserData();
            return instance;
        }
        private void AddUser(string username, string password) { Users.Add(new User(username, password)); }
        public bool CorrectData(string username, string password) { return Users.Any(x => x.CorrectData(username, password)); }
        public void Reset()
        {
            ActualUser = null;
        }
    }
}
