using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.UsersForms
{
    public partial class FormAddPet : Form
    {
        private readonly Repository _repository = new Repository();

        int _ownerId;
        public FormAddPet(int ownerId)
        {
            _ownerId = ownerId;
            InitializeComponent();
        }

        private void textBoxAnimalName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddPet_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSpiece_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            string petName = textBoxAnimalName.Text;
            string petWeight = textBoxWeight.Text;
            string petSpiece = textBoxSpiece.Text;

            var addPetQuery = $"AddAnimal({petName},{petSpiece},{petWeight},{_ownerId})<EOF>";
            var returnedString = _repository.StartClient(addPetQuery);

            if (returnedString.Split('<')[0] == "True")
            {
                MessageBox.Show("Dodano Zwierze!");
            }

            else
            {
                MessageBox.Show("Wystapil blad w trakcie dodawania!");
            }
        }
    }
}
