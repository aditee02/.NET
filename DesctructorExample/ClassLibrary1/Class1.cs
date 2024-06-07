
using System;

namespace ClassLibrary1
{
    public class Sample
    {
        //constructor
        public Sample()
        {
            Console.WriteLine("File i Opened");
        }

        //Destructor
        ~Sample()
        {
            Console.WriteLine("File is Closed");
        }
    }
}