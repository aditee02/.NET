using System;
using College;

namespace OneToOneExample
{
    class Program
    {
        static void Main()
        {
            //student class's object
            Student student =  new Student();
            student.RollNo= 1;
            student.StudentName = "Scott";
            student.Email = "scott@gmail.com";

            //one-to-one relation
            student.branch = new Branch();
            student.branch.BranchName = "computer science engineering";
            student.branch.NoOfSemesters = 8;

            //display
            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemesters);

            Console.ReadKey();
        }
    }
}