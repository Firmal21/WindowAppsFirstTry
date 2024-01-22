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
    public partial class DeleteQuestionsForm : Form
    {
        public DeleteQuestionsForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionsForm_Load(object sender, EventArgs e)
        {

            var questions = QuestionsStorage.GetAllQuestions();

            foreach(var question in questions)
            {
                
                int number = 0;
                for (int i = 0; i < deleteDataGridView.Rows.Count; i++)
                {   
                    number++;   
                }
                deleteDataGridView.Rows.Add(number, question.Text);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void nextButton_Click(object sender, EventArgs e)
        //{
        //    var questions = QuestionsStorage.GetAllQuestions();
        //    var removeQuestionNumber = (deleteQuestionNumber.Text);

        //    if (!(int.TryParse(removeQuestionNumber, out var answerInt)))
        //    {
        //        MessageBox.Show("Пожалуйста, введите число");
        //        return;
        //    }
        //    while (Int32.Parse(removeQuestionNumber) < 1 || Int32.Parse(removeQuestionNumber) > questions.Count)
        //    {
        //        MessageBox.Show("Введите число от 1 до " + questions.Count);
        //        return;
        //    }
        //    var deleteQuestion = questions[Int32.Parse(removeQuestionNumber) - 1];
        //    QuestionsStorage.Remove(deleteQuestion);

        //    string resultsMessage = "Хотите удалить ещё один вопрос?";

        //    string resultsCaption = "";
        //    MessageBoxButtons resultsButtons = MessageBoxButtons.YesNo;
        //    DialogResult showResult;
        //    showResult = MessageBox.Show(resultsMessage, resultsCaption, resultsButtons);

        //    if (showResult == DialogResult.Yes)
        //    {
        //        this.Hide();
        //        DeleteQuestionsForm deleteQuestionForm = new DeleteQuestionsForm();
        //        deleteQuestionForm.Show();
        //    }

        //    else
        //    {
        //        this.Hide();
        //        AdminForm adminForm = new AdminForm();
        //        adminForm.Show();
        //    }
        //}

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void deleteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = deleteDataGridView.CurrentCell.RowIndex;
            deleteDataGridView.Rows.RemoveAt(rowIndex);
            

            var questions = QuestionsStorage.GetAllQuestions();
            var deleteQuestion = questions[rowIndex];
            QuestionsStorage.Remove(deleteQuestion);
        }
    }
}
