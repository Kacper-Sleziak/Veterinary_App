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
    public partial class FormAddVisit : Form
    {
        private readonly Repository _repository = new Repository();
        public FormAddVisit()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void FormAddVisit_Load(object sender, EventArgs e)
        {
            var visitTypes =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient($"GetVisitTypes()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewVisitTypes.DataSource = visitTypes;

            var vets  =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient($"GetVets()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewVetList.DataSource = vets;
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            string freeTermId = textBoxVisitId.Text;
            string animalId = textBoxAnimald.Text;
            string visitTypeId = textBoxVistTypeId.Text;

            var getVetIdQuery= $"GetVetIdByFreeTerml({animalId})<EOF>";
            var vetId = _repository.StartClient(getVetIdQuery);

            var addVisitQuery = $"AddNewVisit{freeTermId},{visitTypeId},{animalId},{vetId}<EOF>";
            var returnedString = _repository.StartClient(addVisitQuery);

            if (returnedString == "true")
            {
                MessageBox.Show("Dodano wizyte");
            }

            else
            {
                MessageBox.Show("Wystapil Blad podczas dodawania");
            }
        }

        private void buttonShowVetVisits_Click(object sender, EventArgs e)
        {
            string vetId = textBoxVetId.Text;
            
            var freeTerms = 
            (DataTable)JsonConvert.DeserializeObject(
            _repository.StartClient($"GetFreeTerms({vetId})<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewFreeTerms.DataSource = freeTerms;
        }
    }
}
