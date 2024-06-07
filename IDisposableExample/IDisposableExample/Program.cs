using System;
using ClassLibrary1;

namespace IDisposableExample
{
    class Program
    {
        static void DoWork()
        {

            //creating object using "using structure"
            using (Sample s = new Sample())
        s.DisplayDataFromDatabase();
            
        }

        static void Main()
        {
            DoWork();
            Console.WriteLine("Some other work here");
            Console.ReadKey();
        }
    }
}