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
                StreamWriter sw = new StreamWriter("UserResults.txt", true, Encoding.Default);
                sw.WriteLine($"{user.Name}#{user.CountRightAnswers}#{user.Diagnoses}");
                sw.Close();
            }

            public static List<User> GetUserResults()
            {
                var reader = new StreamReader("UserResults.txt", Encoding.Default);
                var results = new List<User>();


                while (!reader.EndOfStream)
                {
                    string[] value = reader.ReadLine().Split('#');
                    string name = value[0];
                    int countRightAnswers = int.Parse(value[1]);
                    string diagnoses = value[2];

                    var user = new User(name);
                    user.CountRightAnswers = countRightAnswers;
                    user.Diagnoses = diagnoses;

                    results.Add(user);
                }

                reader.Close();
                return results;
            }
        }
    }
    
}

