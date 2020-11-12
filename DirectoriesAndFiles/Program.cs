using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";

            // Get full path of all directories and files
            
            //string[] allDirectories = Directory.GetDirectories(rootPath);
            //ReadArray(allDirectories);

            string[] includeNestedDirecotries = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            Console.WriteLine("Folders and nested folders:");
            ReadArray(includeNestedDirecotries);

            // Get files in directory
            string[] allFiles = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            Console.WriteLine("");
            Console.WriteLine("Files:");
            ReadArray(allFiles);
        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
