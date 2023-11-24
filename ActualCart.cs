namespace TP_OOP
{
    internal class ActualCart
    {
        static ActualCart? instance;
        private Dictionary<string, int>? Cart;
        private ActualCart() { Cart ??= new Dictionary<string, int>(); }
        public decimal TotalPrice = 0;
        public static ActualCart GetInstance()
        {
            instance ??= new ActualCart();
            return instance;
        }
        public Dictionary<string, int>? GetCart() { return Cart; }
        public void AddToCart(string productName, int amount)
        {
            if (Cart != null)
            {
                if (Cart.ContainsKey(productName))
                {
                    Cart[productName] += amount;
                }
                else
                {
                    Cart.Add(productName, amount);
                }
            }
        }
        public void RemoveFromCart(string productName, int amount)
        {
            if (Cart != null)
            {
                if (Cart.ContainsKey(productName))
                {
                    Cart[productName] -= amount;
                }
                if (Cart[productName] <= 0)
                {
                    Cart.Remove(productName);
                }
            }
        }
        public bool EmptyCart() { return Cart?.Count == 0; }
        public void Reset() { Cart?.Clear(); }
    }
}
