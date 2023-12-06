using System.Text;
using System.IO;
using System;
//using System.Text;

namespace GeniyIdiotClassLibrary
{
    public class FileProvider
    {
        public static void Append(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, true, Encoding.Default);
            writer.WriteLine(value);
            writer.Close();
        }


        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.Default);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void Clear(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }
}

