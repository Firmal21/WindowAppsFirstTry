using System.Text;
using System.IO;
//using System.Text;

namespace GenyiIdiotConsoleApp
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
            var reader = new StreamReader("UserResults.txt", Encoding.Default);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        
    }
}

