class Program2
{
    static void Main()
    {
        System.Console.WriteLine("*****Bank****");
        System.Console.WriteLine("::Login Page::");

        string userName = null,password = null;

        System.Console.WriteLine("Username : ");
        userName = System.Console.ReadLine();

        if(userName != null) {
            System.Console.WriteLine("Password : ");
            password = System.Console.ReadLine();
        }

        if(userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TO DO: Main menu here");
        }

        System.Console.WriteLine("Thank You");
    }
}