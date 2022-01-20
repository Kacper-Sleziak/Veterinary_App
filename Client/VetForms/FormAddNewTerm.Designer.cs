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
            this.monthCalendarPickTerm = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(306, 237);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(214, 51);
            this.buttonAddTerm.TabIndex = 0;
            this.buttonAddTerm.Text = "Dodaj Termin";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // monthCalendarPickTerm
            // 
            this.monthCalendarPickTerm.Location = new System.Drawing.Point(251, 18);
            this.monthCalendarPickTerm.Name = "monthCalendarPickTerm";
            this.monthCalendarPickTerm.TabIndex = 1;
            this.monthCalendarPickTerm.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarPickTerm_DateChanged);
            // 
            // FormAddNewTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendarPickTerm);
            this.Controls.Add(this.buttonAddTerm);
            this.Name = "FormAddNewTerm";
            this.Text = "FormAddNewTerm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.MonthCalendar monthCalendarPickTerm;
    }
}