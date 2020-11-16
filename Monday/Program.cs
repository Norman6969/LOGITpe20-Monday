using System;
using System.IO;

namespace Monday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Sampfiles";
            GetDirectories(rootPath);
            GetFiles(rootPath);
        }

        public static void GetDirectories(string path)
        {
            string[] allDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string filePath = @"C:\Users\opilane\Monday\directoriesData.txt";

            File.WriteAllLines(filePath, allDirectories);

        }

        public static void GetFiles(string path)
        {
            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string filePath = @"C:\Users\opilane\Monday\FilesData.txt";
            File.WriteAllLines(filePath, allFiles);
        }
    }
}
