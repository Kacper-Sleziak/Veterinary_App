using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.VetForms
{
    public partial class FormShowVisits : Form
    {
        private readonly Repository _repository = new Repository();
        private readonly int _vetId;

        public FormShowVisits(int vetId)
        {
            InitializeComponent();
            var getVisitsQuery = $"GetVetVisits({_vetId})<EOF>";
            var table = _repository.StartClient(getVisitsQuery);

            var visits = (DataTable)JsonConvert.DeserializeObject(table.Split('<')[0], (typeof(DataTable)));
            dataGridViewVisits.DataSource = visits;
        }

        private void listViewVisitList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
