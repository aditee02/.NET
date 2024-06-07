namespace ClassLibrary1
{
    public class Student
    {
        public double Securedmarks;
        public double MaxMarks;
        public double Percentage;

    }
    //outerclass
    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            CalculationHelper ch = new CalculationHelper();
            s.Percentage = s.Securedmarks / ch.Multiply(s.MaxMarks,100); 
        }

        //inner class
        public class CalculationHelper
        {
            public double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }
        } 
    }
}