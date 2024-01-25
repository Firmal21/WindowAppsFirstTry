using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class WelcomeForm : Form
    {
        public static string UserName = "sd";
        public WelcomeForm()
        {
            InitializeComponent();
        }

        public void WelcomeForm_Load(object sender, EventArgs e)
        {

            UserName = nameTextBox.Text;
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }
    }
}
