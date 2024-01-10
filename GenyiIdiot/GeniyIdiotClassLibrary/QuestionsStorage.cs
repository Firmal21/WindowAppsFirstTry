using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Text;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        
        public static List<Question> GetAllQuestions()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists("Questions.txt"))
            {
                var value = FileProvider.GetValue("Questions.txt");
                var lines = value.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (var line in lines)
                {
                    var values = line.Split('#');
                    string questionText = values[0];
                    int answer = int.Parse(values[1]);

                    var newQuestion = new Question(questionText, answer);
                    newQuestion.Text = questionText;
                    newQuestion.Answer = answer;

                    questions.Add(newQuestion);
                }
            }

            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 90));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                questions.Add(new Question("У фермера 18 овец, 9 застрелили, сколько овец осталось?", 9));
                questions.Add(new Question("Два мальчика играли в шашки 2 часа. Сколько времени играл каждый мальчик?", 2));
                questions.Add(new Question("Какого цвета потолок? Варианты: 1 - белый, 2 - красный, 3 - полкан, 4 - желлтый", 3));

                SaveQuestions(questions);
            }
            return questions;
        }

        public static void SaveQuestions(List<Question> questions)
        {
            foreach (var question in questions)
            {
                Add(question);
            }
        }

        public static void Add(Question newQuestion)
        {
            
            var value = $"{newQuestion.Text}#{newQuestion.Answer}";
            FileProvider.Append("Questions.txt", value);
            
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetAllQuestions();

            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestion.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }

            questions.Remove(removeQuestion);

            FileProvider.Clear("Questions.txt");
            SaveQuestions(questions);
        }
    }
}

