namespace TP_OOP
{
    partial class CartForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ProductSelect = new ComboBox();
            AmountValue = new NumericUpDown();
            AddToCartButton = new Button();
            PriceLabel = new Label();
            ShowCart = new DataGridView();
            RemoveFromCartButton = new Button();
            CartAclarationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowCart).BeginInit();
            SuspendLayout();
            // 
            // ProductSelect
            // 
            ProductSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductSelect.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ProductSelect.FormattingEnabled = true;
            ProductSelect.Location = new Point(57, 97);
            ProductSelect.Name = "ProductSelect";
            ProductSelect.Size = new Size(244, 46);
            ProductSelect.TabIndex = 0;
            ProductSelect.TextChanged += ProductSelect_TextChanged;
            // 
            // AmountValue
            // 
            AmountValue.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AmountValue.Location = new Point(448, 98);
            AmountValue.Name = "AmountValue";
            AmountValue.Size = new Size(73, 45);
            AmountValue.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AddToCartButton.Location = new Point(563, 97);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(79, 45);
            AddToCartButton.TabIndex = 2;
            AddToCartButton.Text = "+";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(327, 100);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(93, 39);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "Price";
            // 
            // ShowCart
            // 
            ShowCart.AllowUserToAddRows = false;
            ShowCart.AllowUserToDeleteRows = false;
            ShowCart.AllowUserToOrderColumns = true;
            ShowCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ShowCart.DefaultCellStyle = dataGridViewCellStyle1;
            ShowCart.Location = new Point(140, 186);
            ShowCart.Name = "ShowCart";
            ShowCart.ReadOnly = true;
            ShowCart.RowHeadersWidth = 51;
            ShowCart.RowTemplate.Height = 29;
            ShowCart.Size = new Size(299, 239);
            ShowCart.TabIndex = 4;
            // 
            // RemoveFromCartButton
            // 
            RemoveFromCartButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveFromCartButton.Location = new Point(671, 97);
            RemoveFromCartButton.Name = "RemoveFromCartButton";
            RemoveFromCartButton.Size = new Size(79, 45);
            RemoveFromCartButton.TabIndex = 5;
            RemoveFromCartButton.Text = "-";
            RemoveFromCartButton.UseVisualStyleBackColor = true;
            RemoveFromCartButton.Click += RemoveFromCartButton_Click;
            // 
            // CartAclarationLabel
            // 
            CartAclarationLabel.AutoSize = true;
            CartAclarationLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CartAclarationLabel.Location = new Point(459, 391);
            CartAclarationLabel.Name = "CartAclarationLabel";
            CartAclarationLabel.Size = new Size(329, 34);
            CartAclarationLabel.TabIndex = 6;
            CartAclarationLabel.Text = "El carrito se guarda de forma automatica,\r\nasi que puede cerrar esta ventana sin problemas.";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CartAclarationLabel);
            Controls.Add(RemoveFromCartButton);
            Controls.Add(ShowCart);
            Controls.Add(PriceLabel);
            Controls.Add(AddToCartButton);
            Controls.Add(AmountValue);
            Controls.Add(ProductSelect);
            Name = "CartForm";
            Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)AmountValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ProductSelect;
        private NumericUpDown AmountValue;
        private Button AddToCartButton;
        private Label PriceLabel;
        private DataGridView ShowCart;
        private Button RemoveFromCartButton;
        private Label CartAclarationLabel;
    }
}