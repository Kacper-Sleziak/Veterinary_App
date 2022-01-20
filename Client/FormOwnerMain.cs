using Newtonsoft.Json;
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
    public partial class FormOwnerMain : Form
    {
        private readonly Repository _repository = new Repository();
        HashAlgorithm sha = SHA256.Create();
        public FormOwnerMain()
        {
            InitializeComponent();
        }

        private void FormOwnerMain_Load(object sender, EventArgs e)
        {
            reloadEmployees();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewAllEmployees.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                MessageBox.Show("Nie wybrano żadnego lub wybrano więcej niż jednego pracownika.");
                return;
            }

            _repository.StartClient(
                $"DeleteEmployee({int.Parse(dataGridViewAllEmployees.SelectedRows[0].Cells[6].Value.ToString())})<EOF>");
            reloadEmployees();
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
            var jobName = textBoxJabName.Text;
            if (_repository.ValidatePassword(password))
            {
                var registerQuery = $"Register({_repository.GetHash(sha, login)},{_repository.GetHash(sha, password)},{firstName},{lastName},{birthday},{email},{phone},{jobName})<EOF>";
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
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        textBoxFirstName.Clear();
                        textBoxLastName.Clear();
                        textBoxPhone.Clear();
                        textBoxMail.Clear();
                        textBoxJabName.Clear();
                        reloadEmployees();
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
        private void reloadEmployees()
        {
            var employees =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient("GetAllEmployees()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewAllEmployees.DataSource = employees;
            if(employees.Columns.Count != 0)
                dataGridViewAllEmployees.Columns["Id1"].Visible = false;
        }
    }
}
