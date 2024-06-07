using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main()
        {
            try { 
            int a, b;
            Console.WriteLine("Enter First Number : ");
            string input1 = Console.ReadLine();
            a = int.Parse(input1);

            Console.WriteLine("Enter Second Number : ");
            string input2 = Console.ReadLine();
            b = int.Parse(input2);

            int c = a / b;
            Console.WriteLine("Result of division :" + c);
        }catch(DivideByZeroException ex)
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
