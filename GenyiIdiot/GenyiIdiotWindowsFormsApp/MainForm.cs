using GeniyIdiotClassLibrary;

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
        Game game;
        int timeLeft = 5;
        //private List<Question> questions;
        //private Question currentQuestion;
        //private User user;
        //private int countQuestions;
        //private int questionNumber;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Interval = 1000;

            var user = new User(UsersActions.Name);
            game = new Game(user);
           
            ShowNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            
            if(!InputValidator.TryParseToNumber(userAnswerTextBox.Text, out userAnswer, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            game.AcceptAnswer(userAnswer);

            timeLeft = 5;

            if(game.End())
            {
                timer.Stop();
                EndGame();
                return;
            }

            ShowNextQuestion() ;
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();

            questionTextLabel.Text = currentQuestion.Text;
            
            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void EndGame()
        {
            var message = game.CalculateDiagnose();
            MessageBox.Show(message);


            string resultsMessage = "Хотите увидеть прошлые результаты?";
            string resultsCaption = "Конец теста";
            MessageBoxButtons resultsButtons = MessageBoxButtons.YesNo;
            DialogResult showResult;
            showResult = MessageBox.Show(resultsMessage, resultsCaption, resultsButtons);

            if (showResult == DialogResult.Yes)
            {
                UserResultsForm userResultsForm = new UserResultsForm();
                this.Hide();
                userResultsForm.Show();
            }

            else
            {
                string restartMessage = "Хотите начать тест заново?";
                string caption = "Конец теста";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(restartMessage, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    NameForm nameForm = new NameForm();
                    this.Hide();
                    nameForm.Show();
                }

                else Application.Exit();
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = timeLeft.ToString();

            var questions = QuestionsStorage.GetAllQuestions();
            var countQuestions = questions.Count;

            if (timeLeft == 0)
            {
                if (game.EndForTimer())
                {
                    timer.Stop();
                    EndGame();
                    
                }
                else
                {
                    game.RefuseAnsfer();
                    ShowNextQuestion();
                    timeLeft = 5;
                }
            }
            else
            {
               timeLeft--;
            }


        }


        //ДАЛЬШЕ КНОПОЧКИ ХУЕПОЧКИ МОЖНО НЕ ГЛЯДЕТЬ

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

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }


       
    }
}
