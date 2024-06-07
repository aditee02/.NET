using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SortedListExample
{
    internal class Program
    {
        static void Main()
        {
            //create a sortedList
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101,"Scott" },
                {102,"Smith" },
                {103,"Jones" },
                {104,"James" },
                {105,"Anna" },
                

            };

            //Add Element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach(KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }

            //get value based on key
            string eName = employees[105];
            Console.WriteLine("\n Employee name at 105:" + eName);

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n 105 exists:" + k);

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("Scott exists :" + v);

            //index of specific key
            int ki = employees.IndexOfKey(101);
            Console.WriteLine("\nIndex of 101: " + ki);

            //index of specific value
            int vi = employees.IndexOfValue("Allen");
            Console.WriteLine("\nIndex of Allen:" + vi);

            //keys
            Console.WriteLine("\nkeys");
            foreach(int item in employees.Keys)
            {
                Console.WriteLine(item);
            }
          
            //values
            Console.WriteLine("\nValues");
            foreach(string item in employees.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
