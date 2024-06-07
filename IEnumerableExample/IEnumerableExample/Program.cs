using System;
using System.Collections.Generic;

namespace IEnumerableExample
{
    class Program
    {
        static void Main()
        {
            //creat ecollection
            IEnumerable<string> messege;
            messege = new List<string>() { "How are you","Have a great day","Thaks for meeting"};

            //foreach
            Console.WriteLine("IEnumerable : ");
            foreach(string item in messege)
            {
                Console.Write(item);
            }

            //IEnumerator
            Console.WriteLine("\n Enumerator");
            IEnumerator<string> enumerator = messege.GetEnumerator();
            enumerator.Reset();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
