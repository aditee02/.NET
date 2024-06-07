using System;
using System.Collections;

namespace HashTableExample
{
    internal class Program
    {
        static void Main()
        {
            //create a HashTable
            Hashtable employees = new Hashtable()
            {
                {101,"Scott" },
                {102,"Smith" },
                {103,"Jones" },
                {104,"James" },
                {105,"Anna" },
                {"hello",23.1 }


            };

            //Add Element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key+","+item.Value);
            }

            //get value based on key
            if (employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value);
            }else if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value);
            }

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n 105 exists:" + k);

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("Scott exists :" + v);

            
            //keys
            Console.WriteLine("\nkeys");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //values
            Console.WriteLine("\nValues");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
