namespace Client.VetForms
{
    partial class FormAddNewService
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
            this.textBoxVisitType = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddVisitType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVisitType
            // 
            this.textBoxVisitType.Location = new System.Drawing.Point(305, 134);
            this.textBoxVisitType.Name = "textBoxVisitType";
            this.textBoxVisitType.Size = new System.Drawing.Size(191, 27);
            this.textBoxVisitType.TabIndex = 0;
            this.textBoxVisitType.TextChanged += new System.EventHandler(this.textBoxVisitType_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(61, 134);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(191, 27);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(546, 134);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(191, 27);
            this.textBoxDuration.TabIndex = 2;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa Wizyty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Czas Wizyty";
            // 
            // buttonAddVisitType
            // 
            this.buttonAddVisitType.Location = new System.Drawing.Point(305, 223);
            this.buttonAddVisitType.Name = "buttonAddVisitType";
            this.buttonAddVisitType.Size = new System.Drawing.Size(191, 78);
            this.buttonAddVisitType.TabIndex = 6;
            this.buttonAddVisitType.Text = "Dodaj Typ Wizyty";
            this.buttonAddVisitType.UseVisualStyleBackColor = true;
            this.buttonAddVisitType.Click += new System.EventHandler(this.buttonAddVisitType_Click);
            // 
            // FormAddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddVisitType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxVisitType);
            this.Name = "FormAddNewService";
            this.Text = "FormAddNewService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVisitType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddVisitType;
    }
}