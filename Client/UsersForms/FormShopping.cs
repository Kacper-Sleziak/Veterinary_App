using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.UsersForms
{
    public partial class FormShopping : Form
    {
        private readonly Repository _repository = new Repository();

        public FormShopping()
        {
            InitializeComponent();
        }

        private void reloadOrders()
        {
            var orders =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient("GetProducts()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridView1.DataSource = orders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormShopping_Load(object sender, EventArgs e)
        {
            reloadOrders();
        }
    }
}
