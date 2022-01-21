using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.UsersForms
{
    public partial class FormShopping : Form
    {
        private readonly Repository _repository = new Repository();
        private readonly int _ownerId;
        public FormShopping(int ownerId)
        {
            InitializeComponent();
            _ownerId = ownerId;
        }

        private void reloadOrders()
        {
            var orders =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient("GetProducts()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewProducts.DataSource = orders;
            foreach(DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                    dataGridViewCart.Columns.Add(column.Clone() as DataGridViewColumn);
            }
        }

        private void FormShopping_Load(object sender, EventArgs e)
        {
            reloadOrders();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewProducts.SelectedRows.Count;
            if (rowsCount == 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewProducts.SelectedRows[0].Clone();
                int index = 0;
                foreach (DataGridViewCell cell in dataGridViewProducts.SelectedRows[0].Cells)
                {
                    row.Cells[index].Value = cell.Value;
                    index++;
                }
                dataGridViewProducts.SelectedRows[0].Cells[3].Value = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString()) - numericUpDownAmount.Value;
                row.Cells[3].Value = numericUpDownAmount.Value;
                dataGridViewCart.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Nie wybrano produktu!");
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewProducts.SelectedRows.Count;
            if (rowsCount == 1)
            {
                numericUpDownAmount.Maximum = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewCart.SelectedRows.Count;
            if (rowsCount == 1)
            {
                int productId = int.Parse(dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString());
                var row = dataGridViewProducts.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => int.Parse(r.Cells[0].Value.ToString()) == productId);
                row.Cells[3].Value = int.Parse(dataGridViewCart.SelectedRows[0].Cells[3].Value.ToString()) +
                                     int.Parse(row.Cells[3].Value.ToString());

                dataGridViewCart.Rows.Remove(dataGridViewCart.SelectedRows[0]);
            }

            MessageBox.Show("Nie wybrano produktu!");
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            List<int> products = new List<int>(), amounts = new List<int>();
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    products.Add(int.Parse(row.Cells[0].Value.ToString()));
                    amounts.Add(int.Parse(row.Cells[3].Value.ToString()));
                }
                
            }
            Hide();
            var formBuy = new UsersForms.FormBuy(_ownerId, products, amounts);
            formBuy.ShowDialog();
            Show();
        }
    }
}
