using System.Text.Json;

namespace TP_OOP
{
    public partial class MenuForm : CustomForm
    {
        private CustomForm ParentWindow;
        private ClientData? data = null;
        private CartForm? cart = null;
        public MenuForm(CustomForm parent)
        {
            ParentWindow = parent;
            InitializeComponent();
        }
        private void MainForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            ParentWindow.Show();
        }
        private void DataButton_Click(object sender, EventArgs e)
        {
            data ??= new();
            data.Show();
        }
        private void CartButton_Click(object sender, EventArgs e)
        {
            cart ??= new();
            cart.Show();
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (Client.GetInstance().AllFill() && !ActualCart.GetInstance().EmptyCart())
            {
                var responce = MessageBox.Show("Confirma que sus datos y productos del carrito sean correctos?", "Confirmacion de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responce == DialogResult.Yes)
                {
                    var client = Client.GetInstance();
                    var BuyData = new Dictionary<string, string>(){
                        {"Fecha", DateTime.Now.ToString() },
                        {"Nombre", client.FirstName },
                        {"Apellido", client.LastName },
                        {"Direccion", client.Address },
                        {"Numero de Tarjeta", client.CardNumber.ToString() },
                        {"Vencimiento de Tarjeta", client.CardExpDate.ToString("MM/yyyy") },
                        {"Total pagado", ActualCart.GetInstance().TotalPrice.ToString() }
                };
                    FileManager.SaveToJsonFile(BuyData, "BuyData.json");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Falta de datos o carrito vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
