using System.Collections.Generic;
//using System.Text;

namespace GenyiIdiotConsoleApp
{
    public class QuestonStorage2
    {
         
        public static void AddQuesion(string question, int answer)
        {
            var value = $"{question}#{answer}";
            FileProvider.Append("QuestionsAndAnswers.txt", value);

        }

        public static List<Question> GetAllQuestions()
        {
            {
                var value = FileProvider.GetValue("QuestionsAndAnswers.txt");
                var lines = value.Split('\n');
                var results = new List<Question>();

                foreach (var line in lines)
                {
                    var lineCount = 0;
                    var values = line.Split('#');
                    string questionText = values[0];
                    int answer = int.Parse(values[1]);

                    var newQuestion = new Question(questionText, answer);
                    newQuestion.Text = questionText;
                    newQuestion.Answer = answer;

                    results.Add(newQuestion);
                }
                return results;
            }
        }
    }
}

