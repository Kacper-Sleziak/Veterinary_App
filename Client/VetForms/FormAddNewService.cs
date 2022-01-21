using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.VetForms
{
    public partial class FormAddNewService : Form
    {
        private readonly Repository _repository = new Repository();
        public FormAddNewService()
        {
            InitializeComponent();
        }
        private void buttonAddVisitType_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBoxDuration.Text)%15 ==0)
            {
                string duration = textBoxDuration.Text;
                string price = textBoxPrice.Text;
                string visitType = textBoxVisitType.Text;
                var addVisitQuery = $"AddVisitType({visitType},{duration},{price})<EOF>";
                var returnedString = _repository.StartClient(addVisitQuery);

                if (returnedString.Split('<')[0] == "True")
                {
                    MessageBox.Show("Dodano Typ wizyty!");
                }

                else
                {
                    MessageBox.Show("Wystapil blad przy dodawaniu");
                }
            }


            else
            {
                MessageBox.Show("Dlugosc wizyty musi byc wielokrotnoscia 15-minutowego bloku czasu!");
            }
        }
    }
}
