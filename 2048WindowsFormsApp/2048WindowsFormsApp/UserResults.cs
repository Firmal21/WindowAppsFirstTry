using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2048WindowsFormsApp
{
    public class UserResults
    {
        public static string Path = "UserResults.json";

        public static void SaveTestResults(User user)
        {
            var userResults = GetUserResults();
            userResults.Add(user);
            Save(userResults);
        }


        public static List<User> GetUserResults()
        {

            if (!FileProvider.Exists(Path))
            {
                return new List<User>();
            }

            //var value = FileProvider.GetValue("Questions.txt");
            var fileData = FileProvider.GetValue(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Newtonsoft.Json.Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }
    }
}
