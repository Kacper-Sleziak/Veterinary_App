namespace Client.UsersForms
{
    partial class FormShopping
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCart = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonDeleteFromCart = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(18, 26);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 29;
            this.dataGridViewProducts.Size = new System.Drawing.Size(592, 134);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(18, 9);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(55, 15);
            this.labelProducts.TabIndex = 1;
            this.labelProducts.Text = "Produkty";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(616, 26);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(31, 15);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Ilość";
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Location = new System.Drawing.Point(18, 162);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(43, 15);
            this.labelCart.TabIndex = 5;
            this.labelCart.Text = "Koszyk";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(18, 179);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 29;
            this.dataGridViewCart.Size = new System.Drawing.Size(592, 134);
            this.dataGridViewCart.TabIndex = 4;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(616, 44);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.ReadOnly = true;
            this.numericUpDownAmount.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownAmount.TabIndex = 6;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(616, 73);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(71, 41);
            this.buttonAddToCart.TabIndex = 7;
            this.buttonAddToCart.Text = "Dodaj do koszyka";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonDeleteFromCart
            // 
            this.buttonDeleteFromCart.Location = new System.Drawing.Point(616, 179);
            this.buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            this.buttonDeleteFromCart.Size = new System.Drawing.Size(71, 41);
            this.buttonDeleteFromCart.TabIndex = 8;
            this.buttonDeleteFromCart.Text = "Usuń z koszyka";
            this.buttonDeleteFromCart.UseVisualStyleBackColor = true;
            this.buttonDeleteFromCart.Click += new System.EventHandler(this.buttonDeleteFromCart_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(616, 272);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(71, 41);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Kup";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonDeleteFromCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.dataGridViewProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormShopping";
            this.Text = "FormShopping";
            this.Load += new System.EventHandler(this.FormShopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonDeleteFromCart;
        private System.Windows.Forms.Button buttonBuy;
    }
}