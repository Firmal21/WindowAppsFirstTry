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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.Show();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteQuestionsForm deleteQuestionForm = new DeleteQuestionsForm();
            deleteQuestionForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
