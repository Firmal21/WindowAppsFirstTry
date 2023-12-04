using System;
using System.Linq;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using System.Threading;
using System.Reflection.Emit;
using System.Web;
//using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static GenyiIdiotConsoleApp.Program;
using System.Xml.Serialization;

namespace GenyiIdiotConsoleApp
{
    internal partial class Program
    {
        static void AddNewQuestion()
        {
            while (true)
            {
                bool adminChoise = GetUserChoise("Хотите добавить вопрос?");

                if (adminChoise == true)
                {
                    WriteLine("Введите вопрос: ");
                    string question = ReadLine();
                    Write("Введите ответ на вопрос: ");
                    var answer = GetNumber();

                    var newQuestion = new Question(question, answer);
                    QuestionsStorage.Add(newQuestion);
                    adminChoise = GetUserChoise("Хотите добавить ещё один вопрос?");
                }
                
                if (adminChoise == false)
                    break;
            }

            while (true)
            {
                bool adminChoise = GetUserChoise("Хотите удалить сущесвтующий вопрос?");

                if (adminChoise == true)
                {
                    RemoveQuestion();
                }
                if (adminChoise == false)
                    break;
            }

        }

        private static void RemoveQuestion()
        {
            WriteLine("Введите номер удаляемого вопроса: ");
            var questions = QuestionsStorage.GetAllQuestions();

            for(int i = 0; i < questions.Count; i++)
            {
                WriteLine((i + 1) + ". " + questions[i].Text);
            }

            var removeQuestionNumber = GetNumber();

            while(removeQuestionNumber < 1 ||  removeQuestionNumber > questions.Count)
            {
                WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = GetNumber();
            }

            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionsStorage.Remove(removeQuestion);
        }

        static void Main()
        { 
            while (true)
            {
                WriteLine("Введите свое имя");
                string name = ReadLine();

                User user = new User(name);

                if (user.Name.ToLower() == "admin")
                {
                    AddNewQuestion();
                }
                
                var questions = QuestionsStorage.GetAllQuestions();
                int countQestions = questions.Count;

                var random = new Random();
                
                for (int i = 0; i < countQestions; i++)
                {
                    var randomQestionIndex = random.Next(0, questions.Count);

                    WriteLine("Вопрос " + (i + 1) + " - " + questions[randomQestionIndex].Text);

                    user.Answer = GetNumber();
                    
                    if (questions[randomQestionIndex].Answer == user.Answer)
                        user.AcceptRigthAnswer();

                    questions.RemoveAt(randomQestionIndex);
                    
                }

                WriteLine($"Количествов правильных ответов: {user.CountRightAnswers}");

                int userPoints = Diagnoses.CalculateUserDiagnose(countQestions, user.CountRightAnswers);
                user.Diagnoses = Diagnoses.GetDiagnose(userPoints);
                

                WriteLine($"{user.Name}, ваш диагноз : {user.Diagnoses}");
                UserResultStorage.SaveTestResults(user);

                bool userShowChoise = GetUserChoise("Хотите увидеть предыдущие результаты?");

                if (userShowChoise == true)
                {
                    WriteLine();
                    ShowTestResults();
                }

                
                bool userChoise = GetUserChoise("Хотите начать тест заново?");

                if (userChoise == false)
                    break;

                

            }
        }
       

        static int GetNumber()
        {
            while (true)
            {
                try
                {
                    return int.Parse(ReadLine());
                }
                catch (FormatException)
                {
                    WriteLine("Пожалуйста, введите число");
                }
                catch (OverflowException)
                {
                    WriteLine("Вы ввели слишком большое число");
                }
            }
        }


        static void ShowTestResults()
        {
            var result = UserResultStorage.GetUserResults();
            //StreamReader reader = new StreamReader("UserResults.txt", Encoding.Default);
            WriteLine("{0,-20} {1,18} {2,10}", "Имя", "Кол-во верных ответов", "Диагноз");
            foreach (var user in result) 
            {
                WriteLine("{0,-20} {1,18} {2,12}", user.Name, user.CountRightAnswers, user.Diagnoses);
            }
        }


        static bool GetUserChoise(string message)
        {
            while (true)
            {
                WriteLine($"{message} Введите да или нет.");
                string restartAnswer = ReadLine();

                if (restartAnswer.ToLower().Contains("нет"))
                {
                    
                    return false;
                }

                if (restartAnswer.ToLower().Contains("да"))
                {
                    
                    return true;
                }
            }
        }
    }
}

