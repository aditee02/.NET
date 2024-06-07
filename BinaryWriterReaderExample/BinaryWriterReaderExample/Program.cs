using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriterReaderExample
{
    class Program
    {
        static void Main()
        {
            short countryId = 1;
            string countryName = "Frace";
            long population = 65273511;
            string region = "Wester Europe";
            string filepath =  @"c:\Practice\france.txt";
            FileStream fileStream = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            using (BinaryWriter binaryWriter
= new BinaryWriter(fileStream))
            {
                binaryWriter.Write(countryId); //0001
                binaryWriter.Write(countryName);//100 0100..
                binaryWriter.Write(population);
                binaryWriter.Write(region);
                //binaryWriter.Close();//optional(i case of 'using' construct above
            }
            Console.WriteLine("france.txt created");

            Console.WriteLine("------------------");
            //BinaryReader 
            FileStream fileStream2 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            using (BinaryReader binaryReader = new BinaryReader(fileStream2))
            {
                int countryId_from_file = binaryReader.ReadInt16();
                string countryName_from_file = binaryReader.ReadString();
                long population_from_file = binaryReader.ReadInt64();
                string region_from_file = binaryReader.ReadString();

                Console.WriteLine("Country ID:" + countryId_from_file); Console.WriteLine("Country Name:" + countryName_from_file);
                Console.WriteLine("Population :" + population_from_file);
                Console.WriteLine("Region:" + region_from_file);

            }
            Console.ReadKey();
        }
    }
}
