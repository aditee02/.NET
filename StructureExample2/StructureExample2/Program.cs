using System;

class Program
{
    static void Main()
    {
        //create structure instance
        Marvel m = new Marvel("Thanos");   
        //invoke the properties and methods
        Console.WriteLine(m.CharaterName);
        m.PrintCharaterName();

        //create a structure variable
        sbyte a = 10;

        //create a reference variable and object of string
     //   System.String b = " Hello";

        Console.ReadKey();
    }
}