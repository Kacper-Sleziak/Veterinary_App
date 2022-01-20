using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FormRegister();
            form.ShowDialog();
            Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FormLogin();
            form.ShowDialog();
            Show();
        }
    }
}
