//using System.Text;
using System;
using System.Collections.Generic;

namespace GenyiIdiotConsoleApp
{
    public class Diagnoses
    {
        public string Diagnose { get; set; }
        public int Points { get; set; }

        public Diagnoses(string diagnose, int points)
        {
            Diagnose = diagnose;
            Points = points;
        }

        public static string GetDiagnose(int diagnosePoint)
        { 
            var diagnoses = new Dictionary<int, string>()
            {
                { 0, "кретин"},
                { 1, "идиот"},
                { 2, "дурак"},
                { 3, "нормальный"},
                { 4, "талант"},
                { 5, "гений"}
            };

            return diagnoses[diagnosePoint];
        }

        //public static List<Diagnoses> GetDiagnosesStorage()
        //{
        //    var diagnosesList = new List<Diagnoses>();

        //    diagnosesList.Add(new Diagnoses("кретин", 0));
        //    diagnosesList.Add(new Diagnoses("идиот", 1));
        //    diagnosesList.Add(new Diagnoses("дурак", 2));
        //    diagnosesList.Add(new Diagnoses("нормальный", 3));
        //    diagnosesList.Add(new Diagnoses("талант", 4));
        //    diagnosesList.Add(new Diagnoses("гений", 5));

        //    return diagnosesList;
        //}

        public static int CalculateUserDiagnose(int countQestions, int countRightAnswers)
        {
            
            int diagnosesPersents = (countRightAnswers * 100) / countQestions;
            

            if (diagnosesPersents >= 0 && diagnosesPersents < 16)
                return 0;


            if (diagnosesPersents >= 16 && diagnosesPersents <= 33)
                return 1;

            if (diagnosesPersents >= 34 && diagnosesPersents <= 50)
                return 2;

            if (diagnosesPersents >= 51 && diagnosesPersents <= 67)
                return 3;

            if (diagnosesPersents >= 68 && diagnosesPersents <= 84)
                return 4;

            return 5;


        }
    }
}

