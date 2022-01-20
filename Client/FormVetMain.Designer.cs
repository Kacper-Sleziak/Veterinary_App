
namespace Client
{
    partial class FormVetMain
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
            this.buttonShowVisits = new System.Windows.Forms.Button();
            this.buttonAddNewService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTerm
            // 
            this.buttonAddTerm.Location = new System.Drawing.Point(278, 33);
            this.buttonAddTerm.Name = "buttonAddTerm";
            this.buttonAddTerm.Size = new System.Drawing.Size(206, 43);
            this.buttonAddTerm.TabIndex = 0;
            this.buttonAddTerm.Text = "Dodaj Termin";
            this.buttonAddTerm.UseVisualStyleBackColor = true;
            this.buttonAddTerm.Click += new System.EventHandler(this.buttonAddTerm_Click);
            // 
            // buttonShowVisits
            // 
            this.buttonShowVisits.Location = new System.Drawing.Point(278, 109);
            this.buttonShowVisits.Name = "buttonShowVisits";
            this.buttonShowVisits.Size = new System.Drawing.Size(206, 43);
            this.buttonShowVisits.TabIndex = 1;
            this.buttonShowVisits.Text = "Pokaz Wizyty";
            this.buttonShowVisits.UseVisualStyleBackColor = true;
            this.buttonShowVisits.Click += new System.EventHandler(this.buttonShowVisits_Click);
            // 
            // buttonAddNewService
            // 
            this.buttonAddNewService.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.buttonAddNewService.Location = new System.Drawing.Point(280, 182);
            this.buttonAddNewService.Name = "buttonAddNewService";
            this.buttonAddNewService.Size = new System.Drawing.Size(204, 43);
            this.buttonAddNewService.TabIndex = 2;
            this.buttonAddNewService.Text = "Dodaj Nowa Usluge";
            this.buttonAddNewService.UseVisualStyleBackColor = true;
            this.buttonAddNewService.Click += new System.EventHandler(this.buttonAddNewService_Click);
            // 
            // FormVetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewService);
            this.Controls.Add(this.buttonShowVisits);
            this.Controls.Add(this.buttonAddTerm);
            this.Name = "FormVetMain";
            this.Text = "FormVetMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTerm;
        private System.Windows.Forms.Button buttonShowVisits;
        private System.Windows.Forms.Button buttonAddNewService;
    }
}