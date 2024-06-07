using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystems
{
    internal class Program
    {
        static void Main()
        {
            //binary numbers
            int dec1 = 289 ;
            string binary1 = Convert.ToString(dec1,2);
            Console.WriteLine(binary1);
            int dec2 = Convert.ToInt32(binary1, 2);
            Console.WriteLine(dec2);

            //binary literals
            Console.WriteLine(0b111010);
            int n = 0b1100100;
            n += 1;
            Console.WriteLine(n);

            //octal numbers
            string oct1 = Convert.ToString(dec1, 8);
            Console.WriteLine(oct1);
            int dec3 = Convert.ToInt32(oct1, 8);//octal to decimal
            Console.WriteLine(dec3);


            //Hexadecimal numbers
            int dec4 = 742;
            string hex1  = Convert.ToString(dec4, 16);//decimal to hex
            Console.WriteLine(hex1);

            int dec5 = Convert.ToInt32(hex1, 16);//hexadecimal to decimal
            Console.WriteLine(dec5);//742

            //hexadecimal literals
            int dec6 = 0x64;
            Console.WriteLine(dec6);

            Console.ReadLine();
        }
    }
}
