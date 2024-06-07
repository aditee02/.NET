using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    class Person
    {
        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    class Employee
    {
        public string EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double ExperienceYears { get; set; }
        public double ExperienceMonths {  get; set; }
    }
   class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.PersonName = "miller";
            person1.DateOfBirth = DateTime.Parse("2000-12-31 11:59:59.999 am");
            person1.DateOfBirth = Convert.ToDateTime("2000-12-31 11:59:59.999 am");
            Console.WriteLine(person1.DateOfBirth.ToString());

            Console.WriteLine("Day : " + person1.DateOfBirth.Day);
            Console.WriteLine("Month : " + person1.DateOfBirth.Month);
            Console.WriteLine("Year : " + person1.DateOfBirth.Year);
            Console.WriteLine("Hour : " + person1.DateOfBirth.Hour);
            Console.WriteLine("Minute : " + person1.DateOfBirth.Minute);
            Console.WriteLine("Second : " + person1.DateOfBirth.Second);
            Console.WriteLine("Millisecond : " + person1.DateOfBirth.Millisecond);
            Console.WriteLine("Day of week : " + person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of week : " + (int)person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of year : " + person1.DateOfBirth.DayOfYear);

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1.ToString());

            DateTime dt = DateTime.Parse("2000-12-31 11:59:59.999 am");

            // DateTime dt = DateTime.ParseExact("2000-12-31 11:59:59.999 am","dd/MM/yyyy HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture,System.Globalization.DateTimeStyles.None);

            //DateTime dt = new DateTime("202, 12, 31, 23, 59, 999");
            string str1 = dt.ToString();
            string str2 = dt.ToShortDateString();
            string str3 = dt.ToLongDateString();
            string str4 = dt.ToShortDateString();
            string str5 = dt.ToLongTimeString();
            string str6 = dt.ToString("dd-MM-yyyy  HH:mm:ss");

          //  Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(DateTime.DaysInMonth(2022, 7));

            Console.WriteLine("----------------------");
            Employee emp = new Employee() { EmployeeName = "John",DateOfJoining = DateTime.Parse("2015-01-01")};

            DateTime today = DateTime.Now;
            if (today.CompareTo(emp.DateOfJoining) == 1)
            {
                TimeSpan ts = today.Subtract(emp.DateOfJoining);
                emp.ExperienceYears = Math.Floor(ts.TotalDays / 365);
                emp.ExperienceMonths = Math.Floor((ts.TotalDays - (emp.ExperienceYears * 365)) / 30);
                Console.WriteLine(emp.ExperienceYears + " year and " + emp.ExperienceMonths + " months");
            }
            else
            {
                Console.WriteLine("Date of joining is greater than today's date. Subtraction is not possible");
            }

            Console.WriteLine("----------------------");
            DateTime dt2 = DateTime.Parse("2022-01-01 12:00 am");
            DateTime dt_after_10_days = dt2.AddDays(10);
            Console.WriteLine("After 10 days:" + dt_after_10_days);
            DateTime dt_before_10_days = dt2.AddDays(-10);
            Console.WriteLine("Before 10 days:" + dt_before_10_days);
            DateTime dt_after_20_months_and_5_days = dt2.AddMonths(20).AddDays(5);
            Console.WriteLine("After 20 months and 5 days: " + dt_after_20_months_and_5_days);
            Console.ReadKey();
        }
    }
}
