using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using System.Threading;
using System.Reflection.Emit;
using System.Web;
using System.IO;
//using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace GenyiIdiotConsoleApp
{

    internal class Program
    {

        static void Main(string[] args)
        { 
            while (true)
            {
                int countDiagnoses = 6;
                int countRightAnswers = 0;

                WriteLine("Введите свое имя");
                string name = ReadLine();

                var questions = GetQuestions();
                int countQestions = questions.Count;
                string[] diagnoses = GetDiagnoses(countDiagnoses);
                //var rightAnswers = GetRightAnswers();
                var random = new Random();
                //int[] randomList = Randomize(countQestions);

                for (int i = 0; i < countQestions; i++)
                {
                    var randomQestionIndex = random.Next(0, questions.Count);
                    WriteLine("Вопрос " + (i + 1) + " - " + questions[randomQestionIndex].Text);
                    int userAnswerForFool = CheckForFool();
                    var rightAnswers = questions[randomQestionIndex].Answer;
                    if (rightAnswers == userAnswerForFool)
                        countRightAnswers++;

                    questions.RemoveAt(randomQestionIndex);
                    //questions.RemoveAt(randomQestionIndex);
                }

                WriteLine($"Количествов правильных ответов: {countRightAnswers}");

                int userDiagnosis = GetUserDiagnosis(countQestions, countRightAnswers);

                WriteLine($"{name}, ваш диагноз : {diagnoses[userDiagnosis]} ");
                SaveTestResults(name, countRightAnswers, diagnoses[userDiagnosis]);

                bool userShowChoise = GetUserChoise("Хотите увидеть предыдущие результаты?");
                if (userShowChoise == true)
                    ShowTestResults();

                WriteLine();
                bool userChoise = GetUserChoise("Хотите начать тест заново?");

                if (userChoise == false)
                    break;
            }
        }
        static List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
            questions.Add(new Question("У фермера 18 овец, 9 застрелили, сколько овец осталось?", 9));
            questions.Add(new Question("Два мальчика играли в шашки 2 часа. Сколько времени играл каждый мальчик?", 2));
            questions.Add(new Question("Какого цвета потолок? Варианты: 1 - белый, 2 - красный, 3 - полкан, 4 - желлтый", 3));
            return questions;
        }

        static int CheckForFool()
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
                /* 
                if (long.TryParse(ReadLine(), out var answerInt))
                    return answerInt;

                Write("Пожалуйста, введите число! \n");
                */
            }
        }

        static string[] GetDiagnoses(int countDiagnoses)
        {
            string[] diagnoses = new string[countDiagnoses];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";
            return diagnoses;
        }

        static int GetUserDiagnosis(int countQestions, int countRightAnswers)
        {
            int diagnosesPersents = (countRightAnswers * 100) / countQestions;

            if (diagnosesPersents >= 0 && diagnosesPersents < 16)
                return 0;

            if (diagnosesPersents >= 16 && diagnosesPersents <= 33)
                return 1;

            if (diagnosesPersents >= 34 && diagnosesPersents <= 50)
                return 2;

            if (diagnosesPersents >= 51 && diagnosesPersents <= 67)
                return 3;

            if (diagnosesPersents >= 68 && diagnosesPersents <= 84)
                return 4;

            return 5;
        }
        static void SaveTestResults(string name, int countRightAnswers, string diagnosesMark)
        {
            StreamWriter sw = new StreamWriter("UserResults.txt", true, Encoding.Default);
            sw.WriteLine($"{name}#{countRightAnswers}#{diagnosesMark}");
            sw.Close();
        }
        static void ShowTestResults()
        {
            StreamReader reader = new StreamReader("UserResults.txt", Encoding.Default);
            WriteLine("{0,-20} {1,18} {2,10}", "Имя", "Кол-во верных ответов", "Диагноз");
            while (!reader.EndOfStream)
            {
                string[] value = reader.ReadLine().Split('#');
                string name = value[0];
                int countRightAnswers = int.Parse(value[1]);
                string diagnosesMark = value[2];
                WriteLine("{0,-20} {1,18} {2,12}", name, countRightAnswers, diagnosesMark);
            }

            reader.Close();
        }

        static bool GetUserChoise(string message)
        {
            while (true)
            {
                WriteLine($"{message} Введите да или нет.");
                string restartAnswer = ReadLine();

                if (restartAnswer.ToLower().Contains("нет"))
                {
                    WriteLine();
                    return false;
                }

                if (restartAnswer.ToLower().Contains("да"))
                {
                    WriteLine();
                    return true;
                }
            }
        }
        /*
       static int[] Randomize(int countQestions)
       {
           Random random = new Random();
           int[] numbers = new int[countQestions];
           int count = 0;

           for (int c = 0; c < countQestions; c++)
           {
               numbers[c] = count;
               count++;
           }

           for (int k = countQestions - 1; k >= 1; k--)
           {
               int randomIndex = random.Next(k + 1);
               int tmp = numbers[randomIndex];
               numbers[randomIndex] = numbers[k];
               numbers[k] = tmp;
           }

           return numbers;
       }
       */
    }
}

