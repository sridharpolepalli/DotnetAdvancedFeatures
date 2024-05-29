using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemos.FileStreamDemo
{
    internal class Program
    {
        static void Main()
        {
            string path = "filestream_example.txt";

            // Write data to a file using FileStream
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                fs.WriteByte(65);
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");
                fs.Write(data, 0, data.Length);
            }

            // Read data from a file using FileStream
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                string readText = System.Text.Encoding.UTF8.GetString(data);
                Console.WriteLine(readText);
            }

            // Delete the file
            File.Delete(path);
        }
    }
}

