using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemos.CharStreamDemo
{
    internal class Program
    {
        static void Main()
        {
            string path = "stream_example.txt";

            // Write text to a file using StreamWriter
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello, StreamWriter!");
                sw.WriteLine("This is another line.");
            }

            // Read text from a file using StreamReader
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Delete the file
            File.Delete(path);
        }
    }
}
