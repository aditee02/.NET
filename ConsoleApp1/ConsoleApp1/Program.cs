class Program2
{
    static void Main()
    {
        System.Console.WriteLine("*****Bank****");
        System.Console.WriteLine("::Login Page::");

        string userName = null, password = null;

        System.Console.WriteLine("Username : ");
        userName = System.Console.ReadLine();

        if (userName != null)
        {
            System.Console.WriteLine("Password : ");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {

            int mainMenuChoice = -1;
            do
            {
            System.Console.WriteLine("::Main menu::");
            System.Console.WriteLine("1.Customers");
            System.Console.WriteLine("2.Accounts");
            System.Console.WriteLine("3.Funds Transfer");
            System.Console.WriteLine("4.Funds Trannsfer Statement");
            System.Console.WriteLine("5.Account Statement");
            System.Console.WriteLine("0.Exit");

            System.Console.WriteLine("Enter Choice:");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
          
                switch (mainMenuChoice)
                {
                    case 1:CustomerMenu();
                        break;
                    case 2:AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;



                }

            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        System.Console.WriteLine("Thank You");
        System.Console.ReadKey();
    }

    static void CustomerMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n Customer Menu");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2.Delete Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.View Customer");
            System.Console.WriteLine("5.Back to Main Menu");


            System.Console.WriteLine("Enter Choice : ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int AccountMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n Account Menu");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2.Delete Account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("5.Back to Main Menu");


            System.Console.WriteLine("Enter Choice : ");
            AccountMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (AccountMenuChoice != 0);
    }
}