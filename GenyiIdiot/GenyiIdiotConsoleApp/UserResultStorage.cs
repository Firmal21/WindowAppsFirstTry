using System.Text;
using static System.Console;
using System.IO;
using System.Collections.Generic;
//using System.Text;

namespace GenyiIdiotConsoleApp
{
    internal partial class Program
    {
        public class UserResultStorage
        {
            public static void SaveTestResults(User user)
            {
                var value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnoses}";
                FileProvider.Append("userResults.txt", value);
                
            }

            public static List<User> GetUserResults()
            {
                var value = FileProvider.GetValue("UserResults.txt");
                var lines = value.Split('\n');
                var results = new List<User>();

                foreach (var line in lines) 
                {
                    var values = line.Split('#');
                    string name = values[0];
                    int countRightAnswers = int.Parse(values[1]);
                    string diagnoses = values[2];

                    var user = new User(name);
                    user.CountRightAnswers = countRightAnswers;
                    user.Diagnoses = diagnoses;

                    results.Add(user);
                }
                return results;
            }
        }
    }
}

