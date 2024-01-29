﻿using Newtonsoft.Json;
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
            int usersCount = 0;
            //var results = UserResults.GetUserResults();

            //foreach (var result in results)
            //{

            //    (result.Score);
            //}





            var results = UserResults.GetUserResults();

            foreach (var result in results)
            {
                if(result.Score >= highScore)
                {
                    highScore = result.Score;
                }
            }

            //foreach (var result in results)
            //{
            //    usersCount++;
            //    //(result.Score);
            //}
            //for (int i = 1; i != usersCount; i++)
            //{
            //    if (results[i].Score >= highScore)
            //    {
            //      highScore = results[i].Score;
            //    }
            //}
            return  highScore;
        }
      
        
    }
}
