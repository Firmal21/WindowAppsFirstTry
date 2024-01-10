//using System.Text;
namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string Name { get; set; }
        public int CountRightAnswers { get; set; }
        public int Answer { get; set; }
        public string Diagnose { get; set; }
        public static bool Choise { get; set; }

        public User(string name)
        {
            Name = name;
            Diagnose = "Неизвестен";
        }
        public void AcceptRigthAnswer()
        {
            CountRightAnswers++;
        }

    }
}

