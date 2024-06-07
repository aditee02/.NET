using static System.Console;
using warehouse;
using System;

class Program
{
    static void Main()
    {
        //create object of partial class
        Product product = new Product();

        //access properties
        product.ProductID = 101;
        product.Cost = 1000;

        //access methods
        product.CallGetTax();

        ReadKey();
    }

    private static void WriteLine(object v)
    {
        throw new NotImplementedException();
    }
}