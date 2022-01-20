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
            this.dateTimePickerTimePick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(316, 148);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(214, 51);
            this.buttonAddTerm.TabIndex = 0;
            this.buttonAddTerm.Text = "Dodaj Termin";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // dateTimePickerTimePick
            // 
            this.dateTimePickerTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimePick.Location = new System.Drawing.Point(281, 92);
            this.dateTimePickerTimePick.Name = "dateTimePickerTimePick";
            this.dateTimePickerTimePick.Size = new System.Drawing.Size(306, 27);
            this.dateTimePickerTimePick.TabIndex = 3;
            this.dateTimePickerTimePick.ValueChanged += new System.EventHandler(this.dateTimePickerTimePick_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAddNewTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerTimePick);
            this.Controls.Add(this.buttonAddTerm);
            this.Name = "FormAddNewTerm";
            this.Text = "FormAddNewTerm";
            this.Load += new System.EventHandler(this.FormAddNewTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimePick;
        private System.Windows.Forms.Label label2;
    }
}