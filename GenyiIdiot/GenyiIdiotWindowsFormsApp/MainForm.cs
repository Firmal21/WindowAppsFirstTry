using GeniyIdiotClassLibrary;
using GenyiIdiotConsoleApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenyiIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int countQuestions;
        private int questionNumber;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.GetAllQuestions();
            user = new User("Неизвестно");
            countQuestions = questions.Count;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            
            currentQuestion = questions[randomIndex];

            questionTextLabel.Text = currentQuestion.Text;
            questionNumber++;
            questionNumberLabel.Text = "Вопрос - " + questionNumber;

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Int32.Parse(userAnswerTextBox.Text);


            if (currentQuestion.Answer == userAnswer)
                user.AcceptRigthAnswer();

            questions.Remove(currentQuestion);

            var endgame = (questions.Count == 0);
            if(endgame)
            {
                int userPoints = Diagnoses.CalculateUserDiagnose(countQuestions, user.CountRightAnswers);
                user.Diagnoses = Diagnoses.GetDiagnose(userPoints);

                MessageBox.Show(user.Diagnoses);
                return;
            }

            ShowNextQuestion() ;
        }
    }
}
