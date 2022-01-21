namespace Client.UsersForms
{
    partial class FormAddPet
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
            this.buttonAddPet = new System.Windows.Forms.Button();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.textBoxSpiece = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddPet
            // 
            this.buttonAddPet.Location = new System.Drawing.Point(304, 155);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(158, 104);
            this.buttonAddPet.TabIndex = 0;
            this.buttonAddPet.Text = "Dodaj Zwierze";
            this.buttonAddPet.UseVisualStyleBackColor = true;
            this.buttonAddPet.Click += new System.EventHandler(this.buttonAddPet_Click);
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(41, 81);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(183, 27);
            this.textBoxAnimalName.TabIndex = 1;
            this.textBoxAnimalName.TextChanged += new System.EventHandler(this.textBoxAnimalName_TextChanged);
            // 
            // textBoxSpiece
            // 
            this.textBoxSpiece.Location = new System.Drawing.Point(41, 155);
            this.textBoxSpiece.Name = "textBoxSpiece";
            this.textBoxSpiece.Size = new System.Drawing.Size(183, 27);
            this.textBoxSpiece.TabIndex = 2;
            this.textBoxSpiece.TextChanged += new System.EventHandler(this.textBoxSpiece_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(41, 232);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(183, 27);
            this.textBoxWeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imie Zwierzecia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gatunek Zwierzecia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Waga Zwierzecia";
            // 
            // FormAddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxSpiece);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.buttonAddPet);
            this.Name = "FormAddPet";
            this.Text = "FormAddPet";
            this.Load += new System.EventHandler(this.FormAddPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPet;
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.TextBox textBoxSpiece;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}