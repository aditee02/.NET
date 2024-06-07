using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionExample
{
    internal class Program
    {
        static void Main()
        {
            //^ - value starting
            //$ - value ending
            //* - unlimited values
            Regex regex = new Regex("[0-9]");
            Console.WriteLine("Enter a digit:");
            string inputValue = Console.ReadLine();
            bool result = regex.IsMatch(inputValue);
            Console.WriteLine(result);
            if(result == true)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();
        }
    }
}
