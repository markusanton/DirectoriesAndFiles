using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define paths
            string rootPath = @"C:\Users\opilane\samples";
            string foldersTxt = @"C:\Users\opilane\samples\folders.txt";
            string filesTxt = @"C:\Users\opilane\samples\files.txt";

            // Read directories and files
            string[] includeNestedDirecotries = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            string[] allFiles = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            
            // Write to txt
            File.WriteAllLines(foldersTxt, includeNestedDirecotries);
            File.WriteAllLines(filesTxt, allFiles);
        }
    }
}
