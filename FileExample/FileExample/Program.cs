using System;
using System.Collections.Generic;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\Practice\India.txt", filePath2 = @"c:\Practice\India2.txt", filePath3 = @"c:\Practice\another.txt";

            File.Create(filePath).Close();
            Console.WriteLine("India.txt created");

            bool exists = File.Exists(filePath);
            if (exists)
            {
                File.Copy(filePath, filePath2);
                Console.WriteLine("Copied India.txt to India2.txt");

                File.Move(filePath2, filePath3);
                Console.WriteLine("Moved India2.txt to another.txt");

                File.Delete(filePath3);
                Console.WriteLine("Another.txt deleted");
            }

            else
            {
                Console.WriteLine("File not found");
            }

            Console.WriteLine("----------------");
            //read write operations
            string filePath4 = @"c:\Practice\dog.txt";
            string content = "The dog is one of the common domestic animal";
            //WriteAllText
            File.WriteAllText(filePath4, content);
            Console.WriteLine("dog.txt created");
            //ReadAllText
            string s = File.ReadAllText(filePath4);
            Console.WriteLine("File read");
            Console.WriteLine(s);
            Console.WriteLine("----------------");

            //collection
            List<string> asia = new List<string> { "Russia", "China", "India" };

            //file path
            string filePath5 = @"c:\Practice\asia.txt";
            File.Create(filePath5).Close();
            //ReadAllLines
            string[] existingContent = File.ReadAllLines(filePath5);
            foreach(string line in existingContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
