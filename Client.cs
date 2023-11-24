namespace TP_OOP
{
    internal class Client
    {
        public string FirstName { get; private set; } = "";
        public string LastName { get; private set; } = "";
        public string Address { get; private set; } = "";
        public string CardNumber { get; private set; } = "";
        public DateTime CardExpDate { get; private set; } = new(day: 01, month: 01, year: 2000);
        private static Client? instance;
        private Client() { }
        public void SetClient(string firstname, string lastname, string address, string cardnumber, DateTime cardexpdate)
        {
            instance ??= new Client();
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            CardNumber = String.Join("", cardnumber.Split("-", StringSplitOptions.TrimEntries));
            CardExpDate = cardexpdate;
        }
        public static Client GetInstance()
        {
            instance ??= new Client();
            return instance;
        }
        public bool AllFill()
        {
            return FirstName != "" && LastName != "" && Address != "" && CardNumber != "" && CardExpDate != new DateTime(day: 01, month: 01, year: 2000);
        }
        public void Reset()
        {
            instance = null;
            FirstName = "";
            LastName = "";
            Address = "";
            CardNumber = "";
            CardExpDate = new(day: 01, month: 01, year: 2000);
        }
    }
}
