
namespace Client
{
    partial class FormUserMain
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
            this.buttonShowVisits = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.buttonShopping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(299, 12);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(181, 43);
            this.buttonAddVisit.TabIndex = 0;
            this.buttonAddVisit.Text = "Umow Wizyte";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // buttonShowVisits
            // 
            this.buttonShowVisits.Location = new System.Drawing.Point(299, 81);
            this.buttonShowVisits.Name = "buttonShowVisits";
            this.buttonShowVisits.Size = new System.Drawing.Size(181, 43);
            this.buttonShowVisits.TabIndex = 1;
            this.buttonShowVisits.Text = "Pokaz Wizyty";
            this.buttonShowVisits.UseVisualStyleBackColor = true;
            this.buttonShowVisits.Click += new System.EventHandler(this.buttonShowVisits_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(299, 158);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(181, 43);
            this.buttonAddAnimal.TabIndex = 2;
            this.buttonAddAnimal.Text = "Dodaj Zwierze";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // buttonShopping
            // 
            this.buttonShopping.Location = new System.Drawing.Point(299, 232);
            this.buttonShopping.Name = "buttonShopping";
            this.buttonShopping.Size = new System.Drawing.Size(181, 43);
            this.buttonShopping.TabIndex = 3;
            this.buttonShopping.Text = "Zakupy";
            this.buttonShopping.UseVisualStyleBackColor = true;
            this.buttonShopping.Click += new System.EventHandler(this.buttonShopping_Click);
            // 
            // FormUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShopping);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.buttonShowVisits);
            this.Controls.Add(this.buttonAddVisit);
            this.Name = "FormUserMain";
            this.Text = "FormUserMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Button buttonShowVisits;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.Button buttonShopping;
    }
}