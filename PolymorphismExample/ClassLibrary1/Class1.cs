
abstract public class Employee
{
    //instance fields
    public int empID;
    public string empName;
    public string job;

    //static fields
    public static string companyName;

    //instance constructor

    public Employee()
    {

    }
    public Employee(int empID, string empName, string job)
    {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }

    //static constructor
    static Employee()
    {
        companyName = "ABC Industries";
    }

    public abstract string GetHealthInsurance();
}