using GeniyIdiotClassLibrary;
using GenyiIdiotConsoleApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static GenyiIdiotWindowsFormsApp.NameForm;

namespace GenyiIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
       // private NamesBase userName;
        private int countQuestions;
        private int questionNumber;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.GetAllQuestions();
           
            user = new User(NamesBase.Name);
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

                MessageBox.Show(user.Name + ", ваш диагноз: " + user.Diagnoses);
                return;
            }

            ShowNextQuestion() ;
        }

        private void closeAppLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        Point lastPoint;

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
