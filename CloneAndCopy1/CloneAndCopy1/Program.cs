using System;

namespace CloneAndCopy1
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }
    } class Program
        {
            static void Main()
            {
                Employee[] employees = new Employee[]
                {
                    new Employee() { EmployeeName = "Joseph", Role = "Developer" },
                    new Employee() { EmployeeName = "Jack", Role = "Designer" },
                    new Employee() { EmployeeName = "Alexa", Role = "Analyst" },
                };

                //new Array
                Employee[] highlyPaidEmployees = new Employee[3];
            //copyTo
                employees.CopyTo(highlyPaidEmployees, 0);

                //print destination array
                foreach (Employee emp in highlyPaidEmployees)
                {
                    Console.WriteLine(emp.EmployeeName + "," + emp.Role);
                }

            //clone
            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone(); //creates a new array and copes from source array to that new array
            foreach(Employee emp in highlyPaidEmployees2)
            {

                Console.WriteLine(emp.EmployeeName + "," + emp.Role);    
            }

                Console.ReadKey();
            }
        }
    }

