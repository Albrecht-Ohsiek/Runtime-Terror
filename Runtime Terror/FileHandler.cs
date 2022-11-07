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
            List<string> strings = new List<string>();

            FileStream fileStream = File.OpenRead(filename);
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
        public static void writeToFile(string filename, List<string> output)
        {
            FileStream fileStream = File.OpenWrite(filename);
            StreamWriter writer = new StreamWriter(fileStream);

            foreach (var line in output)
            {
                writer.WriteLine(line);
            }

            writer.Close();
            fileStream.Close();
        }
    }
}
