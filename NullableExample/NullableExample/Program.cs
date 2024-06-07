using System;

namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;
        public int Age;
    }
    class Progrm
    {
        static void Main()
        {
            //create object
            Person p1 = new Person() { NoOfChildren = 2 };
            Person p2 = new Person() { NoOfChildren = null };

            System.Console.WriteLine(p1.NoOfChildren);

            Console.WriteLine(p2.NoOfChildren ?? 0);

            Person p3 = null;

            //print age
            Console.WriteLine(p3?.Age);

            System.Console.ReadKey();
        }
    }
}