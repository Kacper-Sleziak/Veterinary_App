using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.UsersForms
{
    public partial class FormBuy : Form
    {
        private readonly Repository _repository = new Repository();
        private readonly int _id;
        private readonly List<int> _products;
        private readonly List<int> _amounts;

        public FormBuy(int id, List<int> products, List<int> amounts)
        {
            InitializeComponent();
            _id = id;
            _products = products;
            _amounts = amounts;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            String product = "[";
            foreach (var prod in _products)
            {
                product += prod.ToString();
                product += ";";
            }

            product = product.Remove(product.Length - 1);
            product += "]";
            String amount = "[";
            foreach (var amt in _amounts)
            {
                amount += amt.ToString();
                amount += ";";
            }
            amount = amount.Remove(amount.Length - 1);
            amount += "]";
            var orderQuery =
                $"Order({_id},{DateTime.Now},{textBoxCity.Text},{textBoxZip.Text},{textBoxStreet.Text},{textBoxDelivery.Text},{textBoxApartament.Text},zamowione,{product},{amount})<EOF>";
            var returnedString = _repository.StartClient(orderQuery);

            switch (returnedString)
            {
                case null:
                    MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                    break;
                case "false<EOF>":
                    MessageBox.Show("Wystąpił nieoczekiwany błąd, proszę spróbować ponownie!");
                    break;
                default:
                    MessageBox.Show("Zakupiono!");
                    this.Close();
                    break;
            }
        }
    }
}
