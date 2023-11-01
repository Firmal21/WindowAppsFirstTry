using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using System.Threading;
using System.Reflection.Emit;

namespace GenyiIdiotConsoleApp
{
    internal class Program
    {
        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
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
            return rightAnswer;
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
            for (int k = countQestions-1; k >= 1; k--)
            {
                int randomIndex = random.Next(k + 1);
                int tmp = numbers[randomIndex];
                numbers[randomIndex] = numbers[k];
                numbers[k] = tmp;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            
            bool restart = true;
            while (restart == true)
            {
                WriteLine("Введите свое имя");
                string name = ReadLine();
                int countQestions = 5;
                int countRightAnswers = 0;
                int countDiagnoses = 6;
                string[] questions = GetQuestions(countQestions);
                int[] rightAnswer = GetRightAnswers(countQestions);
                int[] RandomList = Randomize(countQestions);

                for (int i = 0; i < countQestions; i++)
                {
                    WriteLine("Вопрос " + (i + 1) + " - " + questions[RandomList[i]]);
                    int userAnswer = int.Parse(ReadLine());
                    if (rightAnswer[RandomList[i]] == userAnswer)
                    {
                        countRightAnswers++;
                    }
                }
                string[] diagnoses = GetDiagnoses(countDiagnoses);
                WriteLine($"Количествов правильных ответов: {countRightAnswers}");
                WriteLine($"{name}, ваш диагноз : {diagnoses[countRightAnswers]} ");
                WriteLine("Хотите начать тест заново?");
                string restartAnswer = ReadLine();
                if (!restartAnswer.ToLower().Contains("да"))
                {
                    restart = false;
                }    
            }
        }
    }
}

