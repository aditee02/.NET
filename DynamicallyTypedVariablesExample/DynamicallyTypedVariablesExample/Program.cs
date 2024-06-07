using System;

namespace DyamicallyTypedVariabesExample
{ 
    class Student{
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //dynamically typed variable
            dynamic x;

            x = 100;

            x = "Hello";

            x = new Student() { StudentName = "Harsha"};

            Console.WriteLine(x.StudentName as string);
            Console.ReadKey();

        }
    }
}