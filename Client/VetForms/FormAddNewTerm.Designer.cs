namespace Client.VetForms
{
    partial class FormAddNewTerm
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
            this.buttonAddTerm = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.monthCalendarVisits = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(12, 206);
            this.buttonAddTerm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(187, 38);
            this.buttonAddTerm.TabIndex = 0;
            this.buttonAddTerm.Text = "Dodaj Termin";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 15);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Wybierz dzień";
            // 
            // monthCalendarVisits
            // 
            this.monthCalendarVisits.Location = new System.Drawing.Point(12, 33);
            this.monthCalendarVisits.Name = "monthCalendarVisits";
            this.monthCalendarVisits.TabIndex = 7;
            // 
            // FormAddNewTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.monthCalendarVisits);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonAddTerm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddNewTerm";
            this.Text = "FormAddNewTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MonthCalendar monthCalendarVisits;
    }
}