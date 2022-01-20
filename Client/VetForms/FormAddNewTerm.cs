using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.VetForms
{
    public partial class FormAddNewTerm : Form
    {
        private readonly Repository _repository = new Repository();
        private readonly int _vetId;
        public FormAddNewTerm(int vetId)
        {
            _vetId = vetId;
            InitializeComponent();
        }

        private void buttonAddTerm_Click(object sender, EventArgs e)
        {
            DateTime pickedData = dateTimePickerTimePick.Value;
       
            if (pickedData.Minute % 15 == 0 && (0 < DateTime.Compare(pickedData, DateTime.Now)))
            {
                var addTermQuery = $"AddFreeTerm({pickedData},{_vetId})<EOF>";
                var returnedString = _repository.StartClient(addTermQuery);

                if(returnedString.Split('<')[0] == "True")
                {
                    MessageBox.Show("Dodano Termin!");
                }

                else
                {
                    MessageBox.Show("Wystapil blad!");
                }    
            }

            else
            {
                MessageBox.Show("Nieprawidłowa data!");
            }
        }

        private void monthCalendarPickTerm_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePickerTimePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAddNewTerm_Load(object sender, EventArgs e)
        {
            dateTimePickerTimePick.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimePick.CustomFormat = "yyyy-MM-dd-HH-mm";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
