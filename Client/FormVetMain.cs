using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormVetMain : Form
    {
        private readonly int _vetId;
        public FormVetMain(int vetId)
        {
            _vetId = vetId;
            InitializeComponent();
        }

        private void buttonAddTerm_Click(object sender, EventArgs e)
        {
            Hide();
            var formAddTerm = new VetForms.FormAddNewTerm(_vetId);
            formAddTerm.ShowDialog();
            Show();

        }

        private void buttonShowVisits_Click(object sender, EventArgs e)
        {
            Hide();
            var formShowVisits = new VetForms.FormShowVisits();
            formShowVisits.ShowDialog();
            Show();
        }

        private void buttonAddNewService_Click(object sender, EventArgs e)
        {
            Hide();
            var formAddNewService = new VetForms.FormAddNewService();
            formAddNewService.ShowDialog();
            Show();
        }
    }
}
