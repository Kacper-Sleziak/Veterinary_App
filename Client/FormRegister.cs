using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormRegister : Form
    {
        private readonly Repository _repository = new Repository();
        HashAlgorithm sha = SHA256.Create();
        public FormRegister()
        {
            InitializeComponent();
        }
        
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var phone = textBoxPhone.Text;
            var email = textBoxMail.Text;
            var birthday = dateTimePickerBirthday.Text;
            if (_repository.ValidatePassword(password))
            {
                var registerQuery = $"Register({_repository.GetHash(sha, login)},{_repository.GetHash(sha, password)},{firstName},{lastName},{birthday},{email},{phone})<EOF>";
                var returnedString = _repository.StartClient(registerQuery);

                switch (returnedString)
                {
                    case null:
                        MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                        break;
                    case "false<EOF>":
                        MessageBox.Show("Podany login jest już zajęty, wybierz inny!");
                        break;
                    default:
                        MessageBox.Show("Zarejestrowano!");
                        Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Hasło nie jest bezpieczne. powinno zawierać co najmniej jedną małą literę, " +
                            "wielką literą, liczbę oraz znak specjalny. Ponadto hasło powinno zawierać conajmniej 8 znaków!");
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            var validated = textBoxPhone.Text.Count(c => c < '0' || c > '9') == 0;
            if (textBoxPhone.Text.Length > 9) validated = false;
            if (validated) return;
            textBoxPhone.Clear();
            MessageBox.Show("Podaj poprawny numer telefonu!");
        }
    }
}
