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
        private readonly int _vetId;
        public FormAddNewTerm(int vetId)
        {
            _vetId = vetId;
            InitializeComponent();
        }

        private void buttonAddTerm_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendarPickTerm_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
