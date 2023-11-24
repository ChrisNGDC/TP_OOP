namespace TP_OOP
{
    public partial class LogInForm : CustomForm
    {
        public LogInForm()
        {
            InitializeComponent();
            Show();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UserData.GetInstance().CorrectData(UserText.Text, PasswordText.Text))
            {
                ActualCart.GetInstance().Reset();
                Client.GetInstance().Reset();
                UserData.ActualUser = UserText.Text;
                UserText.Text = "";
                PasswordText.Text = "";
                Hide();
                var menu = new MenuForm(this);
                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ShowPassword.Image = Properties.Resources.eye;
            PasswordText.PasswordChar = '\0';
        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            ShowPassword.Image = Properties.Resources.hidden;
            PasswordText.PasswordChar = '✽';
        }
    }
}