using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemos.DirectoryDemo
{
    internal class Program
    {
        static void Main()
        {
            // Create a directory
            string dirPath = "exampleDir";
            Directory.CreateDirectory(dirPath);

            // Check if directory exists
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("Directory created successfully.");

                // List files in the directory
                string[] files = Directory.GetFiles("C:\\1Training\\May2024\\6\\DotnetAdvancedFeatures\\IODemos\\bin\\Debug");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                // Delete the directory
                Directory.Delete(dirPath);
            }
        }

    }
}
