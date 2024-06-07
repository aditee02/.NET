
using System;

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "Scott", "Manager");
        Employee emp2 = new Employee(102, "Allen", "Clerk");
        Employee emp3 = new Employee(103, "Anna", "Clerk");

        //object initializer
        Employee emp1 = new Employee() { empID = 1, empName = "Ford", job = "Executive" };

        System.Console.WriteLine("Company Name : " + Employee.companyName);
        System.Console.WriteLine();

        System.Console.WriteLine("First Employee");
        System.Console.WriteLine(emp1.empID);
        System.Console.WriteLine(emp1.empName);
        System.Console.WriteLine(emp1.job);
        System.Console.WriteLine();


        System.Console.WriteLine("Second Employee");
        System.Console.WriteLine(emp2.empID);
        System.Console.WriteLine(emp2.empName);
        System.Console.WriteLine(emp2.job);
        System.Console.WriteLine();


        System.Console.WriteLine("Third Employee");
        System.Console.WriteLine(emp3.empID);
        System.Console.WriteLine(emp3.empName);
        System.Console.WriteLine(emp3.job);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}