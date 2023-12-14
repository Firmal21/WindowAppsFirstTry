using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenyiIdiotWindowsFormsApp
{
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = Properties.Resources.UserResults;
            //textBox1.SelectionStart = 0;
            //textBox1.SelectionLength = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
