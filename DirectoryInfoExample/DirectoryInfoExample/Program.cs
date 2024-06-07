using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryInfoExample
{
    internal class Program
    {
        static void Main()
        {
            string countriesPath = @"c:\Practice\countries";
            DirectoryInfo directoryInfo = new DirectoryInfo(countriesPath);
            
            //Create
            directoryInfo.Create();
            Console.WriteLine("countries folder created");

            //CreateSubdirectory
            directoryInfo.CreateSubdirectory("India");
            directoryInfo.CreateSubdirectory("USA");
            directoryInfo.CreateSubdirectory("UK");
            Console.WriteLine("India,Uk,USA folders created");

            //FileInfo.Create()
            new FileInfo(directoryInfo.FullName + @"\capitals.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sports.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\population.txt").Create().Close();
            Console.WriteLine("capitals.txt, sports.txt,population.txt files created");

            //MoveTo
            string worldPath = @"c:\Practice\word";
            directoryInfo.MoveTo(worldPath);
            Console.WriteLine("countries moved to world");

            Console.WriteLine("-------------------");
            string dirPath = @"c:\Pracice\word";
            DirectoryInfo directoryInfo1 = new DirectoryInfo(dirPath);
            Console.WriteLine("Exists:" + directoryInfo.Exists);
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Full Name : " + directoryInfo.FullName);
                Console.WriteLine("Name : " + directoryInfo.Name);
                Console.WriteLine("Directory Name :" + directoryInfo.Parent);
                Console.WriteLine("Root :" + directoryInfo.Root);
                Console.WriteLine("CreationTime :" + directoryInfo.CreationTime);
                Console.WriteLine("LastWriteTime :" + directoryInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime :" + directoryInfo.LastAccessTime);
            }

            Console.ReadKey();
        }
    }
}
