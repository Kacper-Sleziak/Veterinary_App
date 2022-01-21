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
    public partial class FormProducts : Form
    {
        private readonly Repository _repository = new Repository();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            reloadProducts();
        }

        private void reloadProducts()
        {
            var products =
                (DataTable)JsonConvert.DeserializeObject(
                    _repository.StartClient("GetProducts()<EOF>").Split('<')[0], (typeof(DataTable)));
            dataGridViewProducts.DataSource = products;
            if (products.Columns.Count != 0)
                dataGridViewProducts.Columns["Id"].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var type = textBoxType.Text;
            var name = textBoxName.Text;
            var amount = textBoxAmount.Text;
            var price = textBoxPrice.Text;

            _repository.StartClient($"AddProduct({type},{name},{amount},{price})<EOF>");
            reloadProducts();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var type = textBoxType.Text;
            var name = textBoxName.Text;
            var amount = textBoxAmount.Text;
            var price = textBoxPrice.Text;

            var rowsCount = dataGridViewProducts.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                MessageBox.Show("Nie wybrano żadnego lub wybrano więcej niż jeden produkt.");
                return;
            }

            _repository.StartClient(
                $"UpdateProduct({int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString())},{type},{name},{amount},{price})<EOF>");
            reloadProducts();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            int rowsCount = dataGridViewProducts.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;
            textBoxType.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
            textBoxName.Text = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            textBoxAmount.Text = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
