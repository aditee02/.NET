using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public int salary { get; set; }
    }

    class Person
    {
        public string PersonName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> employees = new List<Employee>() {
            new Employee(){EmpID = 101,EmpName = "Henry",Job = "Designer",salary = 7232 },
             new Employee() { EmpID = 102, EmpName = "Jack", Job = "Software Engineer", salary = 4500 },
            new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Manager", salary = 1239 },
            new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", salary = 2343 },
            new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", salary =6557}
            };

            //var result = employees.Where(emp => emp.Job == "Manager");
            //IEnumerable<Employee> result = employees.Where(emp =>emp.City == "New York");
            IEnumerable<Employee> result = employees.Where(emp => emp.Job == "Manager");

            Console.WriteLine("--------------------");
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID + "," + item.EmpName +","+ item.Job + "," + item.salary);
            }
            Console.WriteLine("--------------------");
            IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);
            Console.WriteLine("--------------------");
            IOrderedEnumerable<Employee> sortedEmployees1 = employees.OrderBy(emp => emp.salary);

            Console.WriteLine("--------------------");
            IOrderedEnumerable<Employee> sortedEmployees2 = employees.OrderBy(emp => emp.Job).ThenBy(emp =>  emp.EmpName);
            Console.WriteLine("--------------------");
            IOrderedEnumerable<Employee> sortedEmployees3 = employees.OrderByDescending(emp => emp.Job).ThenBy(emp => emp.EmpName);


            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID+","+item.EmpName+""+item.Job+","+item.salary);
            }
            Console.WriteLine("--------------------");
            //where
            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();

            
           Console.WriteLine("--------------------");
            //First
            Employee firstManger = employees.First(emp => emp.Job == "Manager");
            Console.WriteLine(firstManger.EmpID + "," + firstManger.EmpName);

            Console.WriteLine("--------------------");
            //FirstOrDefault
            Employee firstManger2 = employees.FirstOrDefault(emp => emp.Job == "Manager");
            Console.WriteLine(firstManger2.EmpID + "," + firstManger2.EmpName);

            Console.WriteLine("--------------------");
            //FirstOrDefault
            Employee firstManger3 = employees.FirstOrDefault(emp => emp.Job == "clerk");
            if (firstManger3 != null)
            {
                Console.WriteLine(firstManger3.EmpID + "," + firstManger3.EmpName);
            }
            else
            {
                Console.WriteLine("No Clerk in the list");
            }
            Console.WriteLine("--------------------");
            //Last()
           Employee lastEmployee =  employees.Last(emp => emp.Job == "Manager");
            Console.WriteLine(lastEmployee.EmpID + "," + lastEmployee.EmpName + "," + lastEmployee.Job);
            Console.WriteLine("--------------------");
            //LastOrDefault
            Employee lastEmployee2 = employees.LastOrDefault(emp => emp.Job == "Manager");
            if (lastEmployee2 != null)
            {
                Console.WriteLine(lastEmployee2.EmpID + "," + lastEmployee2.EmpName + "," + lastEmployee2.Job);
            }
            else{
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("--------------------");
            //ElementAt()
            Employee resultEmployee1 = employees.Where(emp => emp.Job == "Manager").ElementAt(1) ;
            Console.WriteLine(resultEmployee1.EmpID + "," + resultEmployee1.EmpName + "," + resultEmployee1.Job);
            Console.WriteLine("--------------------");
            //ElementAtOrDefault
            Employee resultEmployee2 = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
            if (resultEmployee2 != null)
            {
                Console.WriteLine(resultEmployee2.EmpID + "," + resultEmployee2.EmpName + "," + resultEmployee2.Job);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("--------------------");
            //Single()
            Employee resultEmployee3 = employees.Single(emp => emp.Job == "Designer");
            Console.WriteLine(resultEmployee3.EmpID+ "," + resultEmployee3.EmpName + "," + resultEmployee3.Job);
            Console.WriteLine("--------------------");
            //SingleOrDefault
            Employee resultEmployee4 = employees.SingleOrDefault(emp => emp.Job == "Clerk");
            if (resultEmployee4 != null)
            {
                Console.WriteLine(resultEmployee4.EmpID + "," +resultEmployee4.EmpName+","+resultEmployee4.Job);
            }
            else
            {
                Console.WriteLine("No matching employees");
            }
            Console.WriteLine("--------------------");
            //Select
            IEnumerable<Person> result1 = employees.Select(emp => new Person() { PersonName = emp.EmpName}).ToList();
             
            foreach(Person item in result1)
            {
                Console.WriteLine(item.PersonName);
            }
            Console.WriteLine("--------------------");
            //Min,max,Sum,Average,Count
            double min = employees.Min(emp => emp.salary);
            double max = employees.Max(emp => emp.salary);
            double sum = employees.Sum(emp => emp.salary);
            double avg = employees.Average(emp => emp.salary);
            double cnt = employees.Count();
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Count: " + cnt);

            Console.WriteLine("--------------------");
            Console.ReadKey();
        }
    }
}
 