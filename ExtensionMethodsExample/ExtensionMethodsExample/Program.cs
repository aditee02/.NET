using System;
using ClassLibrary1;
using ExtentionsNamespace;

namespace ExtensionMethodsExample
{
    class Program
    {
        static void Main()
        {
            //create oject
            Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };

            //call the extension metod
            Console.WriteLine(p.GetDiscount());
            Console.ReadKey();
        }
    }
}

