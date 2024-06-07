using System;

namespace ClassLibrary1
{
    public class Sample : System.IDisposable
    {
        //constructor
        public Sample()
        {
            Console.WriteLine("Database Connected");
        }

        //method
        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading Data frm database");
        }

        //Dispose
        public void Dispose()
        {
            Console.WriteLine("Database Disconnected");
        }
    }
}