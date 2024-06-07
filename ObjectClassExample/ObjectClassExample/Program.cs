using System;
using System.Dynamic;

class Program
{
    static void Main()
    {
        //Create an object of Person class
        System.Object obj = new Person()
        {
            PersonName = "Scott",
            Email = "scott3462@gmail.com"
        };

        //access methods
        Console.WriteLine(obj.Equals(new Person()
        {
            PersonName = "Scott",
            Email = "scott3462@gmail.com"
        }));

        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.GetType().ToString());
        Console.ReadKey();
    }
}