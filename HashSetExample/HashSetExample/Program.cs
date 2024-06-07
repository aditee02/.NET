using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main()
        {
            //create an object of HashSet
            HashSet<string> messeges = new HashSet<string>() { 
                "Good Morning","How are You","Have A good day"
            };

            //Add
            messeges.Add("Good Luck");

            //Remove
            messeges.Remove("have a good day");

            //Remove
            messeges.RemoveWhere(m => m.EndsWith("You"));

            //Search - Contains
            bool b = messeges.Contains("Good Morning");
            Console.WriteLine("Contains : " + b);

            //count
            Console.WriteLine("Count :"+messeges.Count);

            //foreach
            foreach(string messege in messeges)
            {
                Console.WriteLine(messege);
            }

            Console.WriteLine("----------------");

            //create two HashSets
            HashSet<string> employee2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };

            HashSet<string> newEmployees2022 = new HashSet<string>() { "Amar", "Akhil", "John", "Scot", "Smith", "David" };

            //Union
            employee2021.UnionWith(newEmployees2022);
            foreach(string item in employee2021)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            //IntersectWith
            employee2021.IntersectWith(newEmployees2022);
            foreach(string item in employee2021)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            Console.ReadKey();
        }
    }
}
