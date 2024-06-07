using System;

namespace CloneAndCopy1
{
    class Employee : ICloneable
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }

        public Object Clone()
        {
            Employee new_one = new Employee() { EmployeeName = this.EmployeeName, Role = this.Role };
            return new_one;
        }
    }
        class Program
        {
            static void Main()
            {
                Employee[] employees = new Employee[]
                {
                    new Employee() { EmployeeName = "Joseph", Role = "Developer" },
                    new Employee() { EmployeeName = "Jack", Role = "Designer" },
                    new Employee() { EmployeeName = "Alexa", Role = "Analyst" },
                };

                //deep copy
                Employee[] employees_deep_copy = new Employee[employees.Length];

                for (int i = 0; i < employees.Length; i++)
                {

                    var result = (Employee)employees[i].Clone();
                    employees_deep_copy[i] = result;

                }

                Console.WriteLine("Deep Copy");
                foreach (Employee emp in employees_deep_copy)
                {
                    if (!(emp is null))
                    {
                        Console.WriteLine(emp.EmployeeName + "," + emp.Role);
                    }
                    else
                    {
                        Console.WriteLine("null Object");
                    }
                }
           

            Console.WriteLine("-------------------------");
            Employee[] highlyPaidEmployees = new Employee[5];
            //copyTo
            employees.CopyTo(highlyPaidEmployees, 2);
            employees[0].Role = "Changed";

            //print destination array
            foreach (Employee emp in highlyPaidEmployees) { 

                if (!(emp is null))
                {
                    Console.WriteLine(emp.EmployeeName + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
        }


            Console.WriteLine("\nDeep copy after changing:");
            foreach (Employee emp in employees_deep_copy)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.EmployeeName + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.ReadKey();
            }
        }
    }
