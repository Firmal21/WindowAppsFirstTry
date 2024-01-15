using Newtonsoft.Json;
using System;
using System.Collections.Generic;

//using System.Text;


namespace GeniyIdiotClassLibrary
{

    public class UserResultStorage
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

            var value = FileProvider.GetValue("Questions.txt");
            var fileData = FileProvider.GetValue(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace("UserResults.json", jsonData);
        }
    }
}

