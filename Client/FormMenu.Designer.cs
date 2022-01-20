
namespace Client
{
    partial class FormMenu
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
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.buttonCheckVisits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(328, 33);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(161, 47);
            this.buttonAddVisit.TabIndex = 0;
            this.buttonAddVisit.Text = "Umow Wizyte";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // buttonCheckVisits
            // 
            this.buttonCheckVisits.Location = new System.Drawing.Point(328, 106);
            this.buttonCheckVisits.Name = "buttonCheckVisits";
            this.buttonCheckVisits.Size = new System.Drawing.Size(161, 50);
            this.buttonCheckVisits.TabIndex = 1;
            this.buttonCheckVisits.Text = "Sprawdz Wizyty";
            this.buttonCheckVisits.UseVisualStyleBackColor = true;
            this.buttonCheckVisits.Click += new System.EventHandler(this.buttonCheckVisits_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheckVisits);
            this.Controls.Add(this.buttonAddVisit);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Button buttonCheckVisits;
    }
}