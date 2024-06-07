using System;
using System.Collections.Generic;

namespace ICompareExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string job { get; set; }
    }

    class CustomComparare : IComparer<Employee>
    {
        public int Compare(Employee x,Employee y)
        {
            return x.EmpID - y.EmpID;
        }
    }
    class Program
    {
        static void Main()
        {
            //collection of objects
            List < Employee > employees = new List<Employee>() { 
            new Employee(){EmpID = 104,EmpName = "Mary",job = "Designer"},
            new Employee(){EmpID = 102,EmpName = "Alexa",job = "Manager"},
            new Employee(){EmpID = 101,EmpName = "Steven",job = "Consultant"},
            new Employee(){EmpID = 103,EmpName = "Jade",job = "Analyst"},
            };

            CustomComparare customeComparer = new CustomComparare();
            employees.Sort(customeComparer);

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.EmpID + ","+emp.EmpName+","+emp.job);

            }

            Console.ReadKey();
        }
    }
}
