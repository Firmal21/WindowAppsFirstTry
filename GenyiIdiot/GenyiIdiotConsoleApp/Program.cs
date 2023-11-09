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
                WriteLine("Введите свое имя");
                string name = ReadLine();
                int countQestions = 8;
                int countRightAnswers = 0;
                int countDiagnoses = 6;
                string[] questions = GetQuestions(countQestions);
                int[] rightAnswer = GetRightAnswers(countQestions);
                int[] RandomList = Randomize(countQestions);

                for (int i = 0; i < countQestions; i++)
                {
                    WriteLine("Вопрос " + (i + 1) + " - " + questions[RandomList[i]]);

                    string userAnswerString = ReadLine();
                    int userAnswerForFool = CheckForFool(userAnswerString);
                    
                    if (rightAnswer[RandomList[i]] == userAnswerForFool)
                    {
                        countRightAnswers++;
                    }
                }
                string[] diagnoses = GetDiagnoses(countDiagnoses);
                WriteLine($"Количествов правильных ответов: {countRightAnswers}");
                int diagnosesMark = GetDiagnosesMark(countQestions, countRightAnswers);
                WriteLine($"{name}, ваш диагноз : {diagnoses[diagnosesMark]} ");
                SaveTestResults(name, countRightAnswers, diagnoses[diagnosesMark]);
                bool userChoise = GetUserChoise("Хотите начать тест заново?");
                if(userChoise ==  false)
                {
                    break;
                }
                  
            }
        }
         static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            questions[5] = "У фермера 18 овец, 9 застрелили, сколько овец осталось?";
            questions[6] = "Два мальчика играли в шашки 2 часа. Сколько времени играл каждый мальчик?";
            questions[7] = "Какого цвета потолок? Варианты: 1 - белый, 2 - красный, 3 - полкан, 4 - желлтый";
            return questions;
        }
        static int[] GetRightAnswers(int countQestions)
        {
            int[] rightAnswer = new int[countQestions];
            rightAnswer[0] = 6;
            rightAnswer[1] = 9;
            rightAnswer[2] = 25;
            rightAnswer[3] = 60;
            rightAnswer[4] = 2;
            rightAnswer[5] = 9;
            rightAnswer[6] = 2;
            rightAnswer[7] = 3;
            return rightAnswer;
        }

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

        static int CheckForFool(string answer)
        {
            while (true)
            {
                if (int.TryParse(answer, out var answerInt))
                { 
                    return answerInt;
                }
                Write("Пожалуйста, введите число! \n");
                answer = ReadLine();
                
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

        static int GetDiagnosesMark(int countQestions, int countRightAnswers)
        {
            int diagnosesMark = (100/ countQestions) * countRightAnswers;
            if (diagnosesMark >= 0 && diagnosesMark < 16)
                return 0;
            if (diagnosesMark >= 16 && diagnosesMark <= 33)
                return 1;
            if (diagnosesMark >= 34 && diagnosesMark <= 50)
                return 2;
            if (diagnosesMark >= 51 && diagnosesMark <= 67)
                return 3;
            if (diagnosesMark >= 68 && diagnosesMark <= 84)
                return 4;
            else
                return 5;
        }
        static void SaveTestResults(string name, int countRightAnswers, string diagnosesMark)
        {
            try
            {
                
                //Open the Fileа
                StreamWriter sw = new StreamWriter("C:\\Users\\techn\\Desktop\\Code\\Test1.txt", true, Encoding.Default);
                //Writeout the numbers 1 to 10 on the same line.
                sw.WriteLine($"Участник {name} ответил верно на {countRightAnswers} вопросов и получил диагноз: {diagnosesMark}");
                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Запись результата теста произведена успешно");
            }
        }
    }
}

