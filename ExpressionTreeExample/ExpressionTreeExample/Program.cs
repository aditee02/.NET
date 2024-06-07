using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionTreeExample
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
     class Program
    {
        

        static void Main()
        {
            //create object of Student class
            Student s = new Student() { StudentID = 101, StudentName = "Scott", Age = 15 };

            //create expression tree with Func
            Expression<Func<Student,bool> >expression = st => st.Age > 12 && st.Age <20;

            //compile expression using compile method to invoke it as Delegate
            Func<Student, bool> myDelegates = expression.Compile();

            //Execute the method
            bool result = myDelegates.Invoke(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
