using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Activity_3_form_basics
{
    internal class File_Handler
    {
        // Methode to read specific file and print... Specify filename
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
