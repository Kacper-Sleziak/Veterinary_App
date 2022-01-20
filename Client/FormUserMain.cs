using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormUserMain : Form
    {
        int _ownerId;
        public FormUserMain(int ownerId)
        {
            _ownerId = ownerId;
            InitializeComponent();
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            Hide();
            var formAddVisit = new UsersForms.FormAddVisit();
            formAddVisit.ShowDialog();
            Show();
        }

        private void buttonShowVisits_Click(object sender, EventArgs e)
        {
            Hide();
            var formShowVisits = new UsersForms.FormShowVisits();
            formShowVisits.ShowDialog();
            Show();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            var formAddPet = new UsersForms.FormAddPet(_ownerId);
            formAddPet.ShowDialog();
            Show();
        }
    }
}
