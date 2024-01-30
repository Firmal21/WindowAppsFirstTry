using Newtonsoft.Json;
using System.Collections.Generic;


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

            var fileData = FileProvider.GetValue(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Newtonsoft.Json.Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

        public static int GetHighScore()
        {
            int highScore = 0;
            var results = UserResults.GetUserResults();

            foreach (var result in results)
            {
                if(result.Score >= highScore)
                {
                    highScore = result.Score;
                }
            }

            return  highScore;
        }
      
        
    }
}
