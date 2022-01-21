using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client.UsersForms
{
    public partial class FormShowVisits : Form
    {
        private int _ownerId;
        private readonly Repository _repository = new Repository();
        public FormShowVisits(int ownerId)
        {
            _ownerId = ownerId;
            InitializeComponent();
        }

        private void labelVisits_Click(object sender, EventArgs e)
        {

        }

        private void listBoxVisits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFindVisits_Click(object sender, EventArgs e)
        {
            try
            {
                int animalId = int.Parse(textBoxPetName.Text);
                var visits =
                    (DataTable)JsonConvert.DeserializeObject(
                        _repository.StartClient($"GetVisitsOfAnimal({animalId})<EOF>").Split('<')[0], (typeof(DataTable)));
                dataGridViewShowPets.DataSource = visits;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Musisz podac liczbe calkowita!");
            }
            
        }

        private void FormShowVisits_Load(object sender, EventArgs e)
        {
            var animals =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient($"GetAnimals({_ownerId})<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewShowVisits.DataSource = animals;
        }
    }
}
