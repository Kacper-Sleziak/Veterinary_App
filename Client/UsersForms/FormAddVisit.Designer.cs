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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFreeTerms
            // 
            this.dataGridViewFreeTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeTerms.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewFreeTerms.Name = "dataGridViewFreeTerms";
            this.dataGridViewFreeTerms.RowHeadersWidth = 51;
            this.dataGridViewFreeTerms.RowTemplate.Height = 29;
            this.dataGridViewFreeTerms.Size = new System.Drawing.Size(170, 271);
            this.dataGridViewFreeTerms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wolne Terminy";
            // 
            // FormAddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFreeTerms);
            this.Name = "FormAddVisit";
            this.Text = "AddVisit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowVisits;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.DataGridView dataGridViewFreeTerms;
        private System.Windows.Forms.Label label1;
    }
}