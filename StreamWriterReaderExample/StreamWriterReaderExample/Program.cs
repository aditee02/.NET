using System;
using System.IO;

namespace StreamWriterReaderExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\europe.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //4 ways to create new object of StreamWriter
            //StreamWriter streamWriter = new StreamWriter(filePath);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //StreamWriter streamWriter = fileInfo.AppendText();
            using (StreamWriter streamWriter = fileInfo.CreateText())
            {
                streamWriter.WriteLine("Russia has population about x");
                //some code here
                streamWriter.WriteLine("Germany has population about y");
                //some code here
                streamWriter.WriteLine("United Kigdom has population about z");
                //streamWriter.Close();//optional
            }

            Console.WriteLine("europe.txt created");


            Console.WriteLine("------------");

            //3 ways to create object of StreamReader
            //StreamReader stremReader = new Streamreader(filePath);
            //StreamReader streamReader = fileInfo.Opentext()
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream2))
            {
                Console.WriteLine("\nFile Read. File content is:");

                ////To read full file
                //string content_from_file = streamReader.ReadToEnd();
                //Console.WriteLine(content_from_file);

                //To read part-by-part(10 characters)
                char[] buffer = new char[10];
                int char_count;
                do
                {
                   char_count = streamReader.Read(buffer, 0, 10);
                    string s1 = new string(buffer);
                    Console.WriteLine(s1);
                } while (char_count > 0);
                }
                Console.ReadKey();
        }
    }
}
