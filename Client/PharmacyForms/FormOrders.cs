using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client.PharmacyForms
{
    public partial class FormOrders : Form
    {
        private readonly Repository _repository = new Repository();
        public FormOrders()
        {
            InitializeComponent();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            var rowsCount = dataGridViewOrders.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                MessageBox.Show("Nie wybrano żadnego lub wybrano więcej niż jedno zamówienie.");
                return;
            }
            _repository.StartClient(
                $"UpdateOrder({dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString()},{dataGridViewOrders.SelectedRows[0].Cells[1].Value.ToString()},{dataGridViewOrders.SelectedRows[0].Cells[2].Value.ToString()}," +
                $"{dataGridViewOrders.SelectedRows[0].Cells[3].Value.ToString()},{dataGridViewOrders.SelectedRows[0].Cells[4].Value.ToString()},{dataGridViewOrders.SelectedRows[0].Cells[5].Value.ToString()}," +
                $"{dataGridViewOrders.SelectedRows[0].Cells[6].Value.ToString()},{dataGridViewOrders.SelectedRows[0].Cells[7].Value.ToString()},wyslana)<EOF>");
        }
        private void reloadOrders()
        {
            var orders =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient("GetAllOrders()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewOrders.DataSource = orders;
            if (orders.Columns.Count != 0)
                dataGridViewOrders.Columns["Id"].Visible = false;
        }
    }
}
