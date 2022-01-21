namespace Client.UsersForms
{
    partial class FormAddVisit
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
            this.dataGridViewFreeTerms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVisitId = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxVistTypeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnimald = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.dataGridViewVisitTypes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVetList = new System.Windows.Forms.DataGridView();
            this.Weterynarze = new System.Windows.Forms.Label();
            this.textBoxVetId = new System.Windows.Forms.TextBox();
            this.buttonShowVetVisits = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVetList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFreeTerms
            // 
            this.dataGridViewFreeTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeTerms.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewFreeTerms.Name = "dataGridViewFreeTerms";
            this.dataGridViewFreeTerms.RowHeadersWidth = 51;
            this.dataGridViewFreeTerms.RowTemplate.Height = 29;
            this.dataGridViewFreeTerms.Size = new System.Drawing.Size(490, 271);
            this.dataGridViewFreeTerms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wolne Terminy";
            // 
            // textBoxVisitId
            // 
            this.textBoxVisitId.Location = new System.Drawing.Point(541, 100);
            this.textBoxVisitId.Name = "textBoxVisitId";
            this.textBoxVisitId.Size = new System.Drawing.Size(150, 27);
            this.textBoxVisitId.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(541, 77);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Podaj Id terminu";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // textBoxVistTypeId
            // 
            this.textBoxVistTypeId.Location = new System.Drawing.Point(541, 166);
            this.textBoxVistTypeId.Name = "textBoxVistTypeId";
            this.textBoxVistTypeId.Size = new System.Drawing.Size(150, 27);
            this.textBoxVistTypeId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(541, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Podaj id typ wizyty";
            // 
            // textBoxAnimald
            // 
            this.textBoxAnimald.Location = new System.Drawing.Point(541, 238);
            this.textBoxAnimald.Name = "textBoxAnimald";
            this.textBoxAnimald.Size = new System.Drawing.Size(150, 27);
            this.textBoxAnimald.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Podaj Id Zwierzecia";
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(541, 311);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(150, 36);
            this.buttonAddVisit.TabIndex = 8;
            this.buttonAddVisit.Text = "Zarezerwuj wizyte";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // dataGridViewVisitTypes
            // 
            this.dataGridViewVisitTypes.AllowUserToDeleteRows = false;
            this.dataGridViewVisitTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitTypes.Location = new System.Drawing.Point(769, 89);
            this.dataGridViewVisitTypes.Name = "dataGridViewVisitTypes";
            this.dataGridViewVisitTypes.RowHeadersWidth = 51;
            this.dataGridViewVisitTypes.RowTemplate.Height = 29;
            this.dataGridViewVisitTypes.Size = new System.Drawing.Size(545, 271);
            this.dataGridViewVisitTypes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1002, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Typy Wizyt";
            // 
            // dataGridViewVetList
            // 
            this.dataGridViewVetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVetList.Location = new System.Drawing.Point(769, 444);
            this.dataGridViewVetList.Name = "dataGridViewVetList";
            this.dataGridViewVetList.RowHeadersWidth = 51;
            this.dataGridViewVetList.RowTemplate.Height = 29;
            this.dataGridViewVetList.Size = new System.Drawing.Size(545, 316);
            this.dataGridViewVetList.TabIndex = 11;
            // 
            // Weterynarze
            // 
            this.Weterynarze.AutoSize = true;
            this.Weterynarze.Location = new System.Drawing.Point(991, 412);
            this.Weterynarze.Name = "Weterynarze";
            this.Weterynarze.Size = new System.Drawing.Size(91, 20);
            this.Weterynarze.TabIndex = 12;
            this.Weterynarze.Text = "Weterynarze";
            // 
            // textBoxVetId
            // 
            this.textBoxVetId.Location = new System.Drawing.Point(144, 426);
            this.textBoxVetId.Name = "textBoxVetId";
            this.textBoxVetId.Size = new System.Drawing.Size(176, 27);
            this.textBoxVetId.TabIndex = 13;
            // 
            // buttonShowVetVisits
            // 
            this.buttonShowVetVisits.Location = new System.Drawing.Point(160, 459);
            this.buttonShowVetVisits.Name = "buttonShowVetVisits";
            this.buttonShowVetVisits.Size = new System.Drawing.Size(142, 53);
            this.buttonShowVetVisits.TabIndex = 14;
            this.buttonShowVetVisits.Text = "Pokaz Wizyty";
            this.buttonShowVetVisits.UseVisualStyleBackColor = true;
            this.buttonShowVetVisits.Click += new System.EventHandler(this.buttonShowVetVisits_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Podaj Id Weterynarza";
            // 
            // FormAddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 791);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonShowVetVisits);
            this.Controls.Add(this.textBoxVetId);
            this.Controls.Add(this.Weterynarze);
            this.Controls.Add(this.dataGridViewVetList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewVisitTypes);
            this.Controls.Add(this.buttonAddVisit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAnimald);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVistTypeId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxVisitId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFreeTerms);
            this.Name = "FormAddVisit";
            this.Text = "AddVisit";
            this.Load += new System.EventHandler(this.FormAddVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowVisits;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.DataGridView dataGridViewFreeTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVisitId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewVisitTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVistTypeId;
        private System.Windows.Forms.TextBox textBoxAnimald;
        private System.Windows.Forms.DataGridView dataGridViewVetList;
        private System.Windows.Forms.Label Weterynarze;
        private System.Windows.Forms.TextBox textBoxVetId;
        private System.Windows.Forms.Button buttonShowVetVisits;
        private System.Windows.Forms.Label label5;
    }
}