using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace AnonymousObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create object of Person class
            Person p = new Person();

            //call Method
            var person = new { PersonName = p.GetPersonName(), Age = p.GetPersonAge(),
            Address = new
            {
                street = "abc",
                city = "xyz"
            }
            };

            //print
            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.city);
            Console.WriteLine(person.Address.street);

            Console.ReadKey();
        }
    }
}
