using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {
            //CreateDirectory
            string countriesFolderPath = @"c:\Practice\coutries";
            Directory.CreateDirectory(countriesFolderPath);
            Console.WriteLine("countries folder created");

            string indiaPath = countriesFolderPath + @"\India";
            string ukPath = countriesFolderPath + @"\UK";
            string usaPath = countriesFolderPath + @"\USA";
            Directory.CreateDirectory(indiaPath);
            Console.WriteLine(usaPath);
            Console.WriteLine(ukPath);
            Console.WriteLine("Sub directorie 'India', 'UK',and 'USA' Created");

            string capitalsFilePath = countriesFolderPath + @"\capitals.txt";
            string sportsFilePath = countriesFolderPath + @"\sports.txt";
            string populationFilePath = countriesFolderPath + @"\population.txt";

            //File.Create
            File.Create(capitalsFilePath).Close();
            File.Create(sportsFilePath).Close();    
            File.Create(populationFilePath).Close();
            Console.WriteLine("Files 'capitals.txt','sports.txt','population.txt' created");

            //Move
            string worldFolderPath = @"c:\practice\word";
            Directory.Move(countriesFolderPath, worldFolderPath);
            Console.WriteLine("countries folder moved to word");

            //GetFiles
            string[] files = Directory.GetFiles(worldFolderPath,"*.txt");
            Console.WriteLine("\n Files"); 
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }

           
            //GetDiretories
            string[] directories = Directory.GetDirectories(worldFolderPath);
            Console.WriteLine("\n Sub directories");

           
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            //Delete
            Directory.Delete(worldFolderPath,true);
            Console.WriteLine("world folder deleted");
            Console.ReadKey();
        }
    }
}
