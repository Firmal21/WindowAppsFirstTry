using GeniyIdiotClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Text;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        public static string Path = "Questions.json";
        public static List<Questions> GetAllQuestions()
        {
            

            if (!FileProvider.Exists(Path))
            {
                var questions = new List<Questions>();
                questions.Add(new Questions("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Questions("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Questions("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Questions("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Questions("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                questions.Add(new Questions("У фермера 18 овец, 9 застрелили, сколько овец осталось?", 9));
                questions.Add(new Questions("Два мальчика играли в шашки 2 часа. Сколько времени играл каждый мальчик?", 2));
                questions.Add(new Questions("Какого цвета потолок? Варианты: 1 - белый, 2 - красный, 3 - полкан, 4 - желлтый", 3));

                SaveQuestions(questions);
                return questions;
            }
            var fileData = FileProvider.GetValue(Path);
            var questionsList = JsonConvert.DeserializeObject<List<Questions>>(fileData);
            return questionsList;
        }

        public static void SaveQuestions(List<Questions> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions);
            FileProvider.Replace(Path, jsonData);
        }

        public static void Add(Questions newQuestion)
        {
            var question = GetAllQuestions();
            question.Add(newQuestion);
            SaveQuestions(question);
            
        }

        public static void Remove(Questions removeQuestion)
        {
            var questions = GetAllQuestions();
            
            questions.Remove(removeQuestion);

            SaveQuestions(questions);
        }
    }
}

