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
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            var parced = InputValidator.TryParseToNumber(newQuestionAnswer.Text, out int userAnswer, out string errorMessage);
            if(!parced)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            var newQuestion = new Questions(newQuestionText.Text, userAnswer);
            QuestionsStorage.Add(newQuestion);

            string resultsMessage = "Хотите добавить ещё один вопрос?";
            string resultsCaption = "";
            MessageBoxButtons resultsButtons = MessageBoxButtons.YesNo;
            DialogResult showResult;
            showResult = MessageBox.Show(resultsMessage, resultsCaption, resultsButtons);

            if (showResult == DialogResult.Yes)
            {
                this.Hide();
                AddQuestionForm addQuestionForm = new AddQuestionForm();
                addQuestionForm.Show();
            }

            else
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
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
