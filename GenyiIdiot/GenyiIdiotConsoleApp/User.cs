//using System.Text;
namespace GenyiIdiotConsoleApp
{
    public class User
    {
        public string Name { get; set; }
        public int CountRightAnswers { get; set; }
        public int Answer { get; set; }
        public string Diagnoses { get; set; }

        public User(string name)
        {
            Name = name;
            Diagnoses = "Неизвестен";
        }
        public void AcceptRigthAnswer()
        {
            CountRightAnswers++;
        }

    }
}

