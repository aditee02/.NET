using System;
using System.Collections;


namespace ArrayListExample
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }

        public double GetAnotherNumber()
        {
            return 10.7;
        }

        public string GetMessage()
        {
            return "Hello";
        }

        public Employee GetEmployee()
        {
            return new Employee() { Employeename = "Scott" };
        }
    }

    class Employee
    {
        public string Employeename { get; set; }
    }
    class Program
    {
        static void Main()
        {
          //create object of ArrayList class
          ArrayList arrayList = new ArrayList() { 100,'A'};

            Sample s = new Sample();

            //Add
            arrayList.Add(s.GetNumber());
            arrayList.Add(s.GetAnotherNumber());
            arrayList.Add(s.GetMessage());
            arrayList.Add(s.GetEmployee());

            //foreach
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
