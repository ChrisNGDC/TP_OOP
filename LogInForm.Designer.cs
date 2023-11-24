using System.Drawing.Drawing2D;

namespace TP_OOP
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TituloInicio = new Label();
            UserText = new TextBox();
            PasswordText = new TextBox();
            UserLabel = new Label();
            PasswordLabel = new Label();
            LogInButton = new Button();
            LogoInicio = new PictureBox();
            ShowPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoInicio).BeginInit();
            SuspendLayout();
            // 
            // TituloInicio
            // 
            TituloInicio.AutoSize = true;
            TituloInicio.BackColor = Color.Transparent;
            TituloInicio.Cursor = Cursors.IBeam;
            TituloInicio.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            TituloInicio.Location = new Point(277, 67);
            TituloInicio.Name = "TituloInicio";
            TituloInicio.Size = new Size(401, 59);
            TituloInicio.TabIndex = 0;
            TituloInicio.Text = "Inicio de sesion";
            // 
            // UserText
            // 
            UserText.BackColor = Color.White;
            UserText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            UserText.Location = new Point(308, 203);
            UserText.Name = "UserText";
            UserText.Size = new Size(300, 33);
            UserText.TabIndex = 1;
            // 
            // PasswordText
            // 
            PasswordText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordText.Location = new Point(308, 282);
            PasswordText.Margin = new Padding(0);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '✽';
            PasswordText.Size = new Size(300, 33);
            PasswordText.TabIndex = 2;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.BackColor = Color.Transparent;
            UserLabel.Cursor = Cursors.IBeam;
            UserLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(171, 206);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(131, 27);
            UserLabel.TabIndex = 3;
            UserLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Cursor = Cursors.IBeam;
            PasswordLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(173, 285);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(129, 27);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(308, 349);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(300, 41);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Iniciar sesion";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // LogoInicio
            // 
            LogoInicio.BackColor = Color.Transparent;
            LogoInicio.Image = Properties.Resources.inicio;
            LogoInicio.Location = new Point(151, 40);
            LogoInicio.Name = "LogoInicio";
            LogoInicio.Size = new Size(116, 110);
            LogoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            LogoInicio.TabIndex = 7;
            LogoInicio.TabStop = false;
            // 
            // ShowPassword
            // 
            ShowPassword.BackColor = Color.Transparent;
            ShowPassword.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPassword.Image = Properties.Resources.hidden;
            ShowPassword.Location = new Point(608, 282);
            ShowPassword.Margin = new Padding(0);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(33, 33);
            ShowPassword.TabIndex = 10;
            ShowPassword.UseVisualStyleBackColor = false;
            ShowPassword.MouseDown += ShowPassword_MouseDown;
            ShowPassword.MouseUp += ShowPassword_MouseUp;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.backgroundLogIn;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 473);
            Controls.Add(ShowPassword);
            Controls.Add(LogoInicio);
            Controls.Add(LogInButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(PasswordText);
            Controls.Add(UserText);
            Controls.Add(TituloInicio);
            Name = "LogInForm";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)LogoInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloInicio;
        private TextBox UserText;
        private TextBox PasswordText;
        private Label UserLabel;
        private Label PasswordLabel;
        private Button LogInButton;
        private PictureBox LogoInicio;
        private Button ShowPassword;
    }
}