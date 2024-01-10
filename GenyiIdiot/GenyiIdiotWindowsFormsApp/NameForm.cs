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
        
        
        public NameForm()
        {
            InitializeComponent();
        }

      

        public void NameForm_Load(object sender, EventArgs e)
        {
          
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            
            UsersActions.Name = userNameTextBox.Text;
            this.Hide();
            if ((UsersActions.Name == "admin"))
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }


        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
