using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Client
{
    public partial class FormLogin : Form
    {
        private readonly Repository _repository = new Repository();
        HashAlgorithm sha = SHA256.Create();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var loginQuery = $"Login({_repository.GetHash(sha, login)},{_repository.GetHash(sha, password)})<EOF>";

            var returnedString = _repository.StartClient(loginQuery);
            switch (returnedString)
            {
                case null:
                    MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                    break;
                case "-1<EOF>":
                    MessageBox.Show("Błędny login lub hasło, spróbuj ponownie!");
                    break;
                default:
                    MessageBox.Show($"Zalogowano! Numer danych osobowych to {returnedString.Substring(0, returnedString.Length - 5)}!");
                    
                    // open menu form
                    var form = new FormMenu();
                    form.Show();
                    form.Activate();
                    this.Hide();
                    break;
            }
        }
    }
}
