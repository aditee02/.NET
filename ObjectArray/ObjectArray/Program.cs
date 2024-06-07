using ClassLibrary1;
using System;

class Program
{
    static void Main()
    {
        //create array of objects
        Employee[] employee = new Employee[]
        {
            new Employee(){EmpID = 101,EmpName = "Scott"},
            new Employee(){EmpID = 102,EmpName = "Smith"},
            new Employee(){EmpID = 103,EmpName = "John"}
        };

        //foreach loop for array of objects
        foreach(Employee item in employee)
        {
            Console.WriteLine(item.EmpID + "," + item.EmpName);
        }
        Console.ReadKey();
    }
}