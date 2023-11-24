using System.Windows.Forms;

namespace TP_OOP
{
    partial class ClientData
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
            LastNameText = new TextBox();
            AddressText = new TextBox();
            CardExpDatePicker = new DateTimePicker();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            AddressLabel = new Label();
            CardNumberLabel = new Label();
            CardExpDateLabel = new Label();
            SaveDataButton = new Button();
            FirstNameText = new TextBox();
            CardNumberText = new TextBox();
            SuspendLayout();
            // 
            // LastNameText
            // 
            LastNameText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameText.Location = new Point(390, 109);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(247, 33);
            LastNameText.TabIndex = 1;
            LastNameText.Validating += LastNameText_Validating;
            // 
            // AddressText
            // 
            AddressText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            AddressText.Location = new Point(390, 174);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(247, 33);
            AddressText.TabIndex = 2;
            AddressText.Validating += AddressText_Validating;
            // 
            // CardExpDatePicker
            // 
            CardExpDatePicker.CustomFormat = "MM/yyyy";
            CardExpDatePicker.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            CardExpDatePicker.Format = DateTimePickerFormat.Custom;
            CardExpDatePicker.Location = new Point(390, 295);
            CardExpDatePicker.Name = "CardExpDatePicker";
            CardExpDatePicker.RightToLeft = RightToLeft.No;
            CardExpDatePicker.ShowUpDown = true;
            CardExpDatePicker.Size = new Size(247, 33);
            CardExpDatePicker.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(200, 55);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(130, 26);
            FirstNameLabel.TabIndex = 5;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(200, 110);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(129, 26);
            LastNameLabel.TabIndex = 6;
            LastNameLabel.Text = "Last Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(200, 175);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(102, 26);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address:";
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            CardNumberLabel.Location = new Point(200, 238);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(154, 26);
            CardNumberLabel.TabIndex = 8;
            CardNumberLabel.Text = "Card Number:";
            // 
            // CardExpDateLabel
            // 
            CardExpDateLabel.AutoSize = true;
            CardExpDateLabel.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            CardExpDateLabel.Location = new Point(200, 301);
            CardExpDateLabel.Name = "CardExpDateLabel";
            CardExpDateLabel.Size = new Size(173, 26);
            CardExpDateLabel.TabIndex = 9;
            CardExpDateLabel.Text = "Expiration Date:";
            // 
            // SaveDataButton
            // 
            SaveDataButton.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDataButton.Location = new Point(310, 370);
            SaveDataButton.Name = "SaveDataButton";
            SaveDataButton.Size = new Size(202, 42);
            SaveDataButton.TabIndex = 10;
            SaveDataButton.Text = "Save changes";
            SaveDataButton.UseVisualStyleBackColor = true;
            SaveDataButton.Click += SaveDataButton_Click;
            // 
            // FirstNameText
            // 
            FirstNameText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameText.Location = new Point(390, 54);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(247, 33);
            FirstNameText.TabIndex = 0;
            FirstNameText.Validating += FirstNameText_Validating;
            // 
            // CardNumberText
            // 
            CardNumberText.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            CardNumberText.Location = new Point(390, 235);
            CardNumberText.Name = "CardNumberText";
            CardNumberText.Size = new Size(247, 33);
            CardNumberText.TabIndex = 11;
            CardNumberText.Validating += CardNumberText_Validating;
            // 
            // ClientData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CardNumberText);
            Controls.Add(SaveDataButton);
            Controls.Add(CardExpDateLabel);
            Controls.Add(CardNumberLabel);
            Controls.Add(AddressLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(CardExpDatePicker);
            Controls.Add(AddressText);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameText);
            Name = "ClientData";
            Text = "ClientData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameText;
        private TextBox LastNameText;
        private TextBox AddressText;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label AddressLabel;
        private Label CardNumberLabel;
        private Label CardExpDateLabel;
        private DateTimePicker CardExpDatePicker;
        private Button SaveDataButton;
        private TextBox CardNumberText;
    }
}