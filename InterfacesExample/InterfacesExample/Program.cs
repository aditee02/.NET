
public interface IEmployee   // prefix I for interfaces strongly recommended
{

    //abstarct methods
    string GetHealthInsuranceAmount();

    //auto properties
    int EmpID { set; get; }
    string EmpName { set; get; }
    string location { set; get; }
}

public class Manager : IEmployee
{
    private int _empID;
    private string _empName;
    private string _location;

   public  int EmpID {
        set
        {
            if (value >= 1000 && value <= 2000)
            {
                _empID = value;
            }
        }
        get
        {
            return _empID;
        }
    }
    public string EmpName {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }
    public string location {
        set
        {
            _location = value;
        }
        get {
            return _location;
        }
    }

    //method implementation of the interface methods
    public string GetHealthInsuranceAmount() {
        return " Additional Health premium amount is : 1000";
    }
}

class Program
{
    static void Main()
    {

         
    }
}