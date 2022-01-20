
namespace Client
{
    partial class FormOwnerMain
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
            this.dataGridViewAllEmployees = new System.Windows.Forms.DataGridView();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelJobName = new System.Windows.Forms.Label();
            this.textBoxJabName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllEmployees
            // 
            this.dataGridViewAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEmployees.Location = new System.Drawing.Point(15, 41);
            this.dataGridViewAllEmployees.Name = "dataGridViewAllEmployees";
            this.dataGridViewAllEmployees.RowTemplate.Height = 25;
            this.dataGridViewAllEmployees.Size = new System.Drawing.Size(783, 178);
            this.dataGridViewAllEmployees.TabIndex = 0;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Location = new System.Drawing.Point(15, 23);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(68, 15);
            this.labelEmployees.TabIndex = 1;
            this.labelEmployees.Text = "Pracownicy";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(15, 225);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń Pracownika";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(686, 238);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(112, 23);
            this.dateTimePickerBirthday.TabIndex = 34;
            this.dateTimePickerBirthday.Value = new System.DateTime(2022, 1, 20, 2, 43, 33, 0);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(568, 277);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 15);
            this.labelMail.TabIndex = 33;
            this.labelMail.Text = "E-mail";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(568, 221);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 15);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Nazwisko";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(568, 294);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(112, 23);
            this.textBoxMail.TabIndex = 31;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(568, 238);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(112, 23);
            this.textBoxLastName.TabIndex = 30;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(450, 277);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(91, 15);
            this.labelPhone.TabIndex = 29;
            this.labelPhone.Text = "Numer telefonu";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(450, 221);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(30, 15);
            this.labelFirstName.TabIndex = 28;
            this.labelFirstName.Text = "Imię";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(450, 294);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(112, 23);
            this.textBoxPhone.TabIndex = 27;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(450, 238);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 23);
            this.textBoxFirstName.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(568, 331);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(37, 15);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Hasło";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(450, 331);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 15);
            this.labelLogin.TabIndex = 24;
            this.labelLogin.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(568, 348);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(112, 23);
            this.textBoxPassword.TabIndex = 23;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(450, 348);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(112, 23);
            this.textBoxLogin.TabIndex = 22;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(450, 407);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(108, 32);
            this.buttonRegister.TabIndex = 21;
            this.buttonRegister.Text = "Zarejestruj";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelJobName
            // 
            this.labelJobName.AutoSize = true;
            this.labelJobName.Location = new System.Drawing.Point(686, 331);
            this.labelJobName.Name = "labelJobName";
            this.labelJobName.Size = new System.Drawing.Size(67, 15);
            this.labelJobName.TabIndex = 36;
            this.labelJobName.Text = "Stanowisko";
            // 
            // textBoxJabName
            // 
            this.textBoxJabName.Location = new System.Drawing.Point(686, 348);
            this.textBoxJabName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJabName.Name = "textBoxJabName";
            this.textBoxJabName.Size = new System.Drawing.Size(112, 23);
            this.textBoxJabName.TabIndex = 35;
            // 
            // FormOwnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.labelJobName);
            this.Controls.Add(this.textBoxJabName);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.dataGridViewAllEmployees);
            this.Name = "FormOwnerMain";
            this.Text = "FormOwnerMain";
            this.Load += new System.EventHandler(this.FormOwnerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllEmployees;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelJobName;
        private System.Windows.Forms.TextBox textBoxJabName;
    }
}