using System.Collections.Generic;
//using System.Text;

namespace GenyiIdiotConsoleApp
{
    public class QuestionsStorage
    {
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 90));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
            questions.Add(new Question("У фермера 18 овец, 9 застрелили, сколько овец осталось?", 9));
            questions.Add(new Question("Два мальчика играли в шашки 2 часа. Сколько времени играл каждый мальчик?", 2));
            questions.Add(new Question("Какого цвета потолок? Варианты: 1 - белый, 2 - красный, 3 - полкан, 4 - желлтый", 3));
            return questions;
        }
    }
}

