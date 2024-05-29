using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemos.PathDemo
{
    internal class Program
    {
        static void Main()
        {
            string fullPath = @"C:\1Training\Material\Module 1.1 - VisualStudio 2.docx";

            string directory = Path.GetDirectoryName(fullPath);
            string extension = Path.GetExtension(fullPath);
            string fileName = Path.GetFileName(fullPath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
            string combinedPath = Path.Combine(@"C:\example\", "newfile.txt");

            Console.WriteLine($"Directory: {directory}");
            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"File Name: {fileName}");
            Console.WriteLine($"File Name Without Extension: {fileNameWithoutExtension}");
            Console.WriteLine($"Combined Path: {combinedPath}");
        }
    }
}
