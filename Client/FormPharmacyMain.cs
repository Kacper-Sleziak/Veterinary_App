using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Client.PharmacyForms;

namespace Client
{
    public partial class FormPharmacyMain : Form
    {
        public FormPharmacyMain()
        {
            InitializeComponent();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FormProducts();
            form.ShowDialog();
            Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FormOrders();
            form.ShowDialog();
            Show();
        }
    }
}
