using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main()
        {
            //create an empty dictionary
            Dictionary<int, string> employee = new Dictionary<int, string>() {
                {101,"Scott" },
                {102,"Smith" },
                { 103,"Allen"}
            };

            //foreach loop or dictionary
            foreach(KeyValuePair<int,string>item in employee)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //get value based on the key
            string s = employee[101];
            Console.WriteLine("\nValue at 101 : " + s);

            //keys
            Dictionary<int, string>.KeyCollection keys = employee.Keys;
            Console.WriteLine("\nKeys:");
            foreach(int item in keys)
            {
                Console.WriteLine(item);
            }

            //Duplicate key exception
            //employee.Add(101, "Scott");

            employee.Remove(102);
            //keys
            Dictionary<int, string>.KeyCollection keys1 = employee.Keys;
            Console.WriteLine("\nKeys:");
            foreach (int item in keys1)
            {
                Console.WriteLine(item);
            }

            //ContainsKey
            bool a = employee.ContainsKey(103);
            Console.WriteLine("Contains key:" + a);
            //ContainsValue
            bool b = employee.ContainsValue("Scott") ;
            Console.WriteLine("Contains Value:" + b); 

            //clear
            employee.Clear();

            Console.ReadKey();
        }
    }
}
