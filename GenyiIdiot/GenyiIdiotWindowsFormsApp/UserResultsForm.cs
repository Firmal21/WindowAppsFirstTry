using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;

namespace GenyiIdiotWindowsFormsApp
{
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultStorage.GetUserResults();

            foreach(var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnose);
            }

            //textBox1.Text = Properties.Resources.UserResults;
            //textBox1.SelectionStart = 0;
            //textBox1.SelectionLength = 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string message = "Хотите начать тест заново?";
            string caption = "Конец теста";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                NameForm nameForm = new NameForm();
                nameForm.Show();
            }

            else Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
