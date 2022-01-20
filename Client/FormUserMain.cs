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
        public FormUserMain()
        {
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
    }
}
