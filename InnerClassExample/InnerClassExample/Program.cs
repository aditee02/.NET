using ClassLibrary1;
using System;

namespace InnerClassExample
{
    class Program
    {
        static void Main()
        {
            //create object of inner class
        ClassLibrary1.MarksCalculation.CalculationHelper ch1 = new ClassLibrary1.MarksCalculation.CalculationHelper();

            //call inner class's method
            Console.WriteLine(ch1.Multiply(10,20));

            //call outer class's method
            ClassLibrary1.MarksCalculation mc = new ClassLibrary1.MarksCalculation();
            Student s = new Student() { Securedmarks = 35, MaxMarks = 50 };

            mc.CalculatePercentage(s);

            mc.CalculatePercentage(s.Percentage);
            Console.ReadKey();
        }
    }
}