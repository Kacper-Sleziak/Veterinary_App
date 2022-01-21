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
            var date = monthCalendarVisits.SelectionStart;
            var compDate = date;
            
            date = date.AddHours(8);
            
            while(!date.Equals(compDate.AddHours(16)))
            {
                var addTermQuery = $"AddFreeTerm({date},{_vetId})<EOF>";
                var returnedString = _repository.StartClient(addTermQuery);
                if (returnedString == "false<EOF>")
                    MessageBox.Show("Wystąpił błąd!");
                date = date.AddMinutes(15);
            }
            MessageBox.Show("Pomyślnie dodano wolne terminy!");
        }
    }
}
