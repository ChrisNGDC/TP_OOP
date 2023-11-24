using System.Text.RegularExpressions;

namespace TP_OOP
{
    public partial class ClientData : CustomForm
    {
        static void ValidateInput(TextBox textbox, string regex)
        {
            if (!Regex.IsMatch(textbox.Text, regex))
            {
                textbox.BackColor = Color.Red;
            }
            else
            {
                textbox.BackColor = Color.LightGreen;
            }
        }
        public ClientData()
        {
            InitializeComponent();
            FirstNameText.Text = Client.GetInstance().FirstName;
            LastNameText.Text = Client.GetInstance().LastName;
            AddressText.Text = Client.GetInstance().Address;
            CardNumberText.Text = Client.GetInstance().CardNumber;
            FirstNameText.Text = Client.GetInstance().FirstName;
            CardExpDatePicker.Value = Client.GetInstance().CardExpDate;
            CardExpDatePicker.MinDate = DateTime.Today.AddMonths(1);
        }
        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            List<TextBox> textboxs = Controls.OfType<TextBox>().ToList();
            foreach (TextBox control in textboxs)
            {
                if (control.BackColor != Color.LightGreen)
                {
                    MessageBox.Show("Error en algun dato/s", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allCorrect = false;
                    break;
                }
            }
            if (allCorrect)
            {
                Client.GetInstance().SetClient(FirstNameText.Text, LastNameText.Text, AddressText.Text, CardNumberText.Text, CardExpDatePicker.Value);
                Hide();
            }
        }

        private void FirstNameText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateInput(FirstNameText, @"^[a-zA-Z]+$");
        }

        private void LastNameText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateInput(LastNameText, @"^[a-zA-Z]+$");
        }

        private void AddressText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateInput(AddressText, @"^[a-zA-Z]+( [a-zA-Z]+)* [0-9]+$");
        }

        private void CardNumberText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateInput(CardNumberText, @"^([0-9]{4}( |-)?){4}$");
        }
    }
}
