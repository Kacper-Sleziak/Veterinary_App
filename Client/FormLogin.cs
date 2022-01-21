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
            var personalDataId = returnedString.Split('<')[0];
            
            switch (returnedString)
            {
                case null:
                    MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                    break;
                case "-1<EOF>":
                    MessageBox.Show("Błędny login lub hasło, spróbuj ponownie!");
                    break;
                case "Error<EOF>":
                    MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                    break;
                default:
                    MessageBox.Show($"Zalogowano! Numer danych osobowych to {returnedString.Substring(0, returnedString.Length - 5)}!");
                    var isEmployeeQuery = $"IsEmployee({returnedString.Substring(0, returnedString.Length - 5)})<EOF>";
                    returnedString = _repository.StartClient(isEmployeeQuery);
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    switch (returnedString)
                    {
                        case null:
                            MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                            break;
                        case "Error<EOF>":
                            MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                            break;
                        case "uzytkownik<EOF>":
                            MessageBox.Show("Zalogowano jako użytkownik!");
                            Hide();
                            var formUser = new FormUserMain(int.Parse(personalDataId));
                            formUser.ShowDialog();
                            Show();
                            break;
                        case "weterynarz<EOF>":
                            MessageBox.Show("Zalogowano jako weterynarz!");
                            Hide();
                            
                            var getEmployeeIdQuery = $"GetEmployee({personalDataId})<EOF>";
                            var employeeId = _repository.StartClient(getEmployeeIdQuery).Split('<')[0];
                            var formVet = new FormVetMain(int.Parse(employeeId));
                            
                            formVet.ShowDialog();
                            Show();
                            break;
                        case "aptekarz<EOF>":
                            MessageBox.Show("Zalogowano jako aptekarz!");
                            Hide();
                            var formPharma = new FormPharmacyMain();
                            formPharma.ShowDialog();
                            Show();
                            break;
                        case "wlasciciel<EOF>":
                            MessageBox.Show("Zalogowano jako właściciel!");
                            Hide();
                            var formOwner = new FormOwnerMain();
                            formOwner.ShowDialog();
                            Show();
                            break;
                        default:
                            MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                            break;
                    }
                    break;
            }
        }
    }
}
