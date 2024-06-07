using System;
using ClassLibrary1;

namespace ExpressionBodiedMembersExample
{
    class Program
    {
        static void Main()
        {
            //create object of Student class
            Student s = new Student()
            {
                Studentname = "Scott"
        };

            Console.WriteLine(s.Studentname);
            Console.WriteLine(s.GetStudentNameLength());

            Console.ReadKey();
        }
    }
}