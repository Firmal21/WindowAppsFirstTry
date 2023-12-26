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
            var newQuestionText = (this.newQuestionText.Text);
            var newQuestionAnswer = (this.newQuestionAnswer.Text);
            if (!(int.TryParse(newQuestionAnswer, out var answerInt)))
            {
                MessageBox.Show("Пожалуйста, введите число");
                return;
            }

            var newQuestion = new Question(newQuestionText, Int32.Parse(newQuestionAnswer));
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
    }
}
