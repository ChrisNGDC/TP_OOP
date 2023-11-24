namespace TP_OOP
{
    public class CustomForm : Form
    {
        public new void Show()
        {
            this.Visible = false;
            this.Visible = true;
            this.CenterToScreen();
        }
    }
}
