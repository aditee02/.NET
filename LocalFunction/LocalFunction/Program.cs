
class Student
{
    //method
    public void DisplayMarks(int marks1,int marks2,int marks3)
    {
        double avgMarks = getAverageMarks();
        System.Console.WriteLine("Marks 1 : " + marks1); 
        System.Console.WriteLine("Marks 2 : " + marks2);
        System.Console.WriteLine("Marks 3 : " + marks3);
        System.Console.WriteLine("Average Marks : " + avgMarks);

        double getAverageMarks()
        {
            double avg;
            avg = (double)(marks1 + marks2 + marks3) / 3;
            return avg;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.DisplayMarks(10, 20, 30);
        System.Console.ReadKey();
    }
}