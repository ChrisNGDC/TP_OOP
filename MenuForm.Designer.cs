namespace TP_OOP
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuLabel = new Label();
            DataButton = new Button();
            CartButton = new Button();
            BuyButton = new Button();
            SuspendLayout();
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            MenuLabel.Location = new Point(93, 31);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(640, 59);
            MenuLabel.TabIndex = 0;
            MenuLabel.Text = "Elija la opcion que desee:";
            // 
            // DataButton
            // 
            DataButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            DataButton.Location = new Point(205, 140);
            DataButton.Name = "DataButton";
            DataButton.Size = new Size(408, 56);
            DataButton.TabIndex = 1;
            DataButton.Text = "Mis Datos";
            DataButton.UseVisualStyleBackColor = true;
            DataButton.Click += DataButton_Click;
            // 
            // CartButton
            // 
            CartButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CartButton.Location = new Point(205, 229);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(408, 56);
            CartButton.TabIndex = 2;
            CartButton.Text = "Carrito";
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BuyButton.Location = new Point(205, 313);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(408, 56);
            BuyButton.TabIndex = 3;
            BuyButton.Text = "Confirmar compra";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BuyButton);
            Controls.Add(CartButton);
            Controls.Add(DataButton);
            Controls.Add(MenuLabel);
            Name = "MenuForm";
            Text = "Menu";
            FormClosing += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MenuLabel;
        private Button DataButton;
        private Button CartButton;
        private Button BuyButton;
    }
}