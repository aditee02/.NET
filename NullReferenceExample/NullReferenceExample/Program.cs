using System;
    
namespace NullReferenceExample
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double CurrentBalance { get; set; }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount,BankAccount destinationAccount,double amount)
        {
            try
            {
                sourceAccount.CurrentBalance -= amount;//it throws the same object of ArgumentNullException
                
            }catch(NullReferenceException ex)
            {
                throw new ArgumentNullException("destinationAccount","You have supplied null value to destinationAccount parameter") ;//it throws the same object of ArgumentNullException
            }


            try
            {
                destinationAccount.CurrentBalance += amount;//it throws a new object of NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("destinationAccount ", "You have supplied null value to destinationAccount parameter");//it throws the same object of ArgumentNullException
            }

        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount bobAccount = new BankAccount() { AccountNumber = 101,AccountHolderName = "Bob",CurrentBalance = 100000};
                BankAccount aliceAccount = new BankAccount() { AccountNumber = 102, AccountHolderName = "Alice", CurrentBalance = 5000 };
                BankAccount stevenBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();
                fundsTransfer.Transfer(bobAccount, stevenBankAccount, 1000);
                Console.WriteLine("Funds Transffered");
            }catch(ArgumentNullException ex)//it catches the same object of NullReferenceException which was re-thrown in the catch block of 'Transfer' method
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}
