using System;
using System.IO;

namespace ExceptionExample { 

    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        public double _currentBalance;
        public double CurrentBalance {
            get => _currentBalance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of 'CurrentBalance' should be a positive number. You have supplied{value}","CurrentBalance");
                }

                _currentBalance = value;
            }
        }
    }

    //custome exception
    class InsufficientFundsException : InvalidOperationException
    {
        public InsufficientFundsException()
        {

        }

        public InsufficientFundsException(string messege) : base(messege)
        {

        }
        public InsufficientFundsException(string messege,Exception innerException) : base(messege, innerException)
        {

        }
    }

    class ExceptionLogger
    {
        public static void AddException(Exception ex)
        {
            string filePath = @"c:\Practice\ErrorLog.txt";
            StreamWriter streamWriter = File.AppendText(filePath);
            streamWriter.WriteLine("\n\nException on:" + DateTime.Now);
            streamWriter.WriteLine(ex.GetType().ToString());
            Console.WriteLine("\nStack Trace");
            streamWriter.WriteLine(ex.StackTrace);
            Console.WriteLine("\nMessege");
            streamWriter.WriteLine(ex.Message);
            streamWriter.Close();
        }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
        {
            try
            {
                if (amount < 0 || amount > 10000)
                {
                    throw new ArgumentOutOfRangeException("amount", 10000, "For funds transfer, the value of amount should be between 1 to 10000");
                }

                if (amount > sourceAccount.CurrentBalance)
                {
                    throw new InsufficientFundsException($"Insufficient balance in the source account. The current balance is{sourceAccount.CurrentBalance}. But the amount to transfer is {amount}");
                }
           sourceAccount.CurrentBalance -= amount;//it throws the same object of ArgumentNullException

            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to sourceAccount parameter",ex);//it throws the same object of ArgumentNullException
            }


            try
            {
                destinationAccount.CurrentBalance += amount;//it throws a new object of NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to destinationAccount parameter",ex);//it throws the same object of ArgumentNullException
            }

        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount bobAccount = new BankAccount() { AccountNumber = 101, AccountHolderName = "Bob", CurrentBalance = 100000 };
                BankAccount aliceAccount = new BankAccount() { AccountNumber = 102, AccountHolderName = "Alice", CurrentBalance = 5000 };
                BankAccount stevenBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();
                fundsTransfer.Transfer(bobAccount, stevenBankAccount, 1000000);
                Console.WriteLine("Funds Transffered");
            }
            catch (ArgumentNullException ex)//it catches the same object of NullReferenceException which was re-thrown in the catch block of 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                if(ex.InnerException!=null)
                        Console.WriteLine(ex.InnerException.Message);
                ExceptionLogger.AddException(ex);
            }catch(ArgumentOutOfRangeException ex) when(ex.ParamName == "amount")//it catches the object of ArgumentOutRangeException which was thrown in the Transfer method
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
                ExceptionLogger.AddException(ex);
            }
            catch(ArgumentException ex)//it catches the object of ArgumentException which was thrown in Transfer method
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }
            catch(InsufficientFundsException ex)//it catches the object of InvalidOperatioonException which was thrown in Transfer method
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ExceptionLogger.AddException(ex);
            }
            catch( InvalidOperationException ex)//it catches the object of InvalidOperationException which was thrown in 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}
