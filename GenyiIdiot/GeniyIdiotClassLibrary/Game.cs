using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        int countQuestions;
        int questionNumber = 1;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAllQuestions();
            countQuestions = questions.Count;

        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];
            questionNumber++;
            return currentQuestion;
        }


        public void AcceptAnswer(int userAnswer)
        {
            if (currentQuestion.Answer == userAnswer)
                user.AcceptRigthAnswer();

            questions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос " + questionNumber;
        }

        public bool End()
        {
            return questions.Count == 0;
        }
        public string CalculateDiagnose()
        {
            int userPoints = Diagnoses.CalculateUserDiagnose(countQuestions, user.CountRightAnswers);
            user.Diagnose = Diagnoses.GetDiagnose(userPoints);
            UserResultStorage.SaveTestResults(user);
            return user.Name + ", ваш диагноз: " + user.Diagnose;
        }
    }
}
