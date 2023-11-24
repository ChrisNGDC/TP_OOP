namespace TP_OOP
{
    public partial class CartForm : CustomForm
    {
        private Dictionary<string, decimal> Products = new(){
            { "Leche", 381.62m },
            { "Cafe", 1944.21m },
            { "Galletitas", 785.00m },
            { "Yerba", 1157.76m },
            { "Biscochos", 291.69m }
        };
        public CartForm()
        {
            InitializeComponent();
            ProductSelect.DataSource = Products.Keys.ToList();
            ShowCart.Columns.Add("Producto", "Producto");
            ShowCart.Columns.Add("Cantidad", "Cantidad");
            RefreshList();
        }
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var cart = ActualCart.GetInstance();
            cart.AddToCart(ProductSelect.Text, (int)AmountValue.Value);
            RefreshList();
            AmountValue.Value = 0;
            ProductSelect.ResetText();
        }
        private void ProductSelect_TextChanged(object sender, EventArgs e)
        {
            PriceLabel.Text = $"${Products[ProductSelect.Text]}";
        }
        private void RefreshList()
        {
            ShowCart.Rows.Clear();
            var cartList = ActualCart.GetInstance().GetCart();
            if (cartList != null)
            {
                decimal totalPrice = 0;
                foreach (var item in cartList)
                {
                    totalPrice += item.Value * Products[item.Key];
                    ShowCart.Rows.Insert(0, item.Key, item.Value);
                }
                ActualCart.GetInstance().TotalPrice = totalPrice;
            }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            var cart = ActualCart.GetInstance();
            cart.RemoveFromCart(ProductSelect.Text, (int)AmountValue.Value);
            RefreshList();
            AmountValue.Value = 0;
            ProductSelect.ResetText();
        }
    }
}
