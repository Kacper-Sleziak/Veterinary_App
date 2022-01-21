namespace Client.UsersForms
{
    partial class FormShowVisits
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
            this.dataGridViewShowPets = new System.Windows.Forms.DataGridView();
            this.Pets = new System.Windows.Forms.Label();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.buttonFindVisits = new System.Windows.Forms.Button();
            this.dataGridViewShowVisits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowPets
            // 
            this.dataGridViewShowPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowPets.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewShowPets.Name = "dataGridViewShowPets";
            this.dataGridViewShowPets.RowHeadersWidth = 51;
            this.dataGridViewShowPets.RowTemplate.Height = 29;
            this.dataGridViewShowPets.Size = new System.Drawing.Size(203, 259);
            this.dataGridViewShowPets.TabIndex = 0;
            // 
            // Pets
            // 
            this.Pets.AutoSize = true;
            this.Pets.Location = new System.Drawing.Point(71, 50);
            this.Pets.Name = "Pets";
            this.Pets.Size = new System.Drawing.Size(74, 20);
            this.Pets.TabIndex = 1;
            this.Pets.Text = "Zwierzeta";
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(322, 95);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(125, 27);
            this.textBoxPetName.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(311, 50);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(138, 20);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "Podaj Id Zwierzecia";
            // 
            // buttonFindVisits
            // 
            this.buttonFindVisits.Location = new System.Drawing.Point(339, 140);
            this.buttonFindVisits.Name = "buttonFindVisits";
            this.buttonFindVisits.Size = new System.Drawing.Size(80, 62);
            this.buttonFindVisits.TabIndex = 5;
            this.buttonFindVisits.Text = "Znajdz Wizyty";
            this.buttonFindVisits.UseVisualStyleBackColor = true;
            this.buttonFindVisits.Click += new System.EventHandler(this.buttonFindVisits_Click);
            // 
            // dataGridViewShowVisits
            // 
            this.dataGridViewShowVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowVisits.Location = new System.Drawing.Point(557, 73);
            this.dataGridViewShowVisits.Name = "dataGridViewShowVisits";
            this.dataGridViewShowVisits.RowHeadersWidth = 51;
            this.dataGridViewShowVisits.RowTemplate.Height = 29;
            this.dataGridViewShowVisits.Size = new System.Drawing.Size(212, 259);
            this.dataGridViewShowVisits.TabIndex = 6;
            this.dataGridViewShowVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wizyty Zwierzecia";
            // 
            // FormShowVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewShowVisits);
            this.Controls.Add(this.buttonFindVisits);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.Pets);
            this.Controls.Add(this.dataGridViewShowPets);
            this.Name = "FormShowVisits";
            this.Text = "ShowVisits";
            this.Load += new System.EventHandler(this.FormShowVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowPets;
        private System.Windows.Forms.Label Pets;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button buttonFindVisits;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewShowVisits;
    }
}