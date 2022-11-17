using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class FileHandler
    {
        public static List<string> readFromFile(string filename)
        {
            string directory = Directory.GetCurrentDirectory();
            string path = Path.Combine(directory, filename);

            List<string> strings = new List<string>();

            FileStream fileStream = File.OpenRead(path);
            StreamReader reader = new StreamReader(fileStream);

            while (reader.EndOfStream != true)
            {
                strings.Add(reader.ReadLine());
            }

            reader.Close();
            fileStream.Close();

            return strings;
        }

        // Method to print List to File, line by line... Specify filename
        public static void writeToFile(string filename, string output)
        {
            string directory = Directory.GetCurrentDirectory();
            string path = Path.Combine(directory, filename);

            FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            
            writer.WriteLine(output);

            writer.Close();
            fileStream.Close();
        }
    }
}
