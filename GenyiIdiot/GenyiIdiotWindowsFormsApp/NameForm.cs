using GeniyIdiotClassLibrary;
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

   

    public partial class NameForm : Form
    {
        //public User user;
        
        public NameForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
          // Name = userNameTextBox.Text;
           // user = new User(name);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //userName = userNameTextBox.Text;

            NamesBase.Name = userNameTextBox.Text;
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        Point lastPoint;
        private void NameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void NameForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
