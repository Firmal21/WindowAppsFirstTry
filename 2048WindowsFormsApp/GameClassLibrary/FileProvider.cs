using System.IO;
using System.Text;

namespace _2048WindowsFormsApp
{
    public class FileProvider
    {
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

        public static void Replace(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default);
            writer.WriteLine(value);
            writer.Close();
        }
    }

}
