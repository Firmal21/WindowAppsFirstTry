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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NameForm nameForm = new NameForm();
            nameForm.Show();
        }

        private void ResultstButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserResultsForm userResultsForm = new UserResultsForm();
            userResultsForm.Show();
        }
    }
}
