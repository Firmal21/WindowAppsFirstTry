﻿using System;
using static System.Console;
//using System.Text;
using GeniyIdiotClassLibrary;

namespace GenyiIdiotConsoleApp
{
    internal partial class Program
    {
       

        static void Main()
        { 
            while (true)
            {
                WriteLine("Введите свое имя");
                string name = ReadLine();

                User user = new User(name);

                if (user.Name.ToLower() == "admin")
                {
                    AdminActions();
                }

                var game = new Game(user);

                while(!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();

                    WriteLine(game.GetQuestionNumberText());
                    WriteLine(currentQuestion.Text);

                    user.Answer = GetNumber();

                    game.AcceptAnswer(user.Answer);
                    
                }

                var message = game.CalculateDiagnose();
                WriteLine(message);
                
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
            int number;
            while (!InputValidator.TryParseToNumber(Console.ReadLine(), out  number, out string errorMessage))
            {
                WriteLine(errorMessage);
            }
            return number;
        }


        static void ShowTestResults()
        {
            var result = UserResultStorage.GetUserResults();
            //StreamReader reader = new StreamReader("UserResults.txt", Encoding.Default);
            WriteLine("{0,-20} {1,18} {2,10}", "Имя", "Кол-во верных ответов", "Диагноз");
            foreach (var user in result) 
            {
                WriteLine("{0,-20} {1,18} {2,12}", user.Name, user.CountRightAnswers, user.Diagnose);
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

        static void AdminActions()
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

                    var newQuestion = new Questions(question, answer);
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

            for (int i = 0; i < questions.Count; i++)
            {
                WriteLine((i + 1) + ". " + questions[i].Text);
            }

            var removeQuestionNumber = GetNumber();

            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = GetNumber();
            }

            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionsStorage.Remove(removeQuestion);
        }
    }
}

