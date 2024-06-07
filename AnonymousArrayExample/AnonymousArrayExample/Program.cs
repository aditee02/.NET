using System;
using System.Collections.Generic;

namespace AnonymousArrayExample
{
    internal class Program
    {
        static void Main()
        {
            //create anonymous array/implicitly typed array
            var persons = new[]
            {
                new { PersonName = "Scott", Email = "acott@gmail.com" },
                new { PersonName = "Smith", Email = "smith@gmail.com" },
                new { PersonName = "allen", Email = "allen@gmail.com" }
            };

            //foreach
            foreach (var item in persons)
            {
                Console.WriteLine(item.PersonName);
                Console.WriteLine(item.Email);
            }
            Console.ReadKey();
        }
    }
}