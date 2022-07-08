using System;
using System.IO;

namespace FileIOOperationDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
            public static void FileExist()
            {
                string path = @"C:\Users\leovo\Desktop\localrepo\New folder (3)MyFile.txt";
                if (File.Exists(path))
                {
                 Console.WriteLine(File.Exists(path));

                }
            }
            
        
    }

   
}
