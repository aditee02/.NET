 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamClassExample
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            //FileStream fileStream = new FileStream(filePath,FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileInfo = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileInfo = File.OpenWrite(filePath);
            //FileStream fileInfo = File.Create();
            FileStream fileStream = fileInfo.Open( FileMode.Create, FileAccess.Write);
            //FileInfo fileInfo = File.OpenWrite();

            //create content
            string content = "Dog is one of the omestic animal";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);

            //Write
            fileStream.Write(bytes, 0, bytes.Length);

            //some work here
            string content2 = "other text here";
            byte[] byte2 = System.Text.Encoding.ASCII.GetBytes(content);
            fileStream.Write(bytes, 0, bytes.Length);

            fileStream.Close();
            Console.WriteLine("dog.txt created");

            Console.WriteLine("--------------------");

            //File reading
            //FileStream fileStream2 = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.Read);
            //FileStream fileStream2 = File.Open(filePath,FileMode.OpenOrCreate,FileAccess.Read);
            //FileStream fileStream2 = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read);
            //FileStream fileStream2 = fileInfo.OpenRead();
            FileStream fileStream2 = fileInfo.OpenRead();

            //create empty byte[]
            byte[] byte3 = new byte[fileStream2.Length];

            //Read
            fileStream2.Read(byte3, 0, (int)fileStream2.Length);

            //convert byte[] to string
            string content3 = Encoding.ASCII.GetString(byte3);
            Console.WriteLine("\n File read.File content is:");
            Console.WriteLine(content3);
            fileStream2.Close();

            Console.ReadKey();


        }
    }
}
