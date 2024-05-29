using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemos.FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write text to a file
            string path = "example.txt";
            string text = "Hello, World!";
            File.WriteAllText(path, text);

            // Read text from a file
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }

            // Copy the file
            string copyPath = "example_copy.txt";
            File.Copy(path, copyPath);

            // Move the file
            string movePath = "example_moved.txt";
            File.Move(copyPath, movePath);

            // Delete the file
            File.Delete(path);
            File.Delete(movePath);
        }
    }
}
