using System;

namespace SwitchExpressionExample
{
    class Program
    {
        static void Main()
        {
            int operation = 1;
        string result;

            //switch expression
            result = operation switch
            {
                1 => "Customer",
                2 => "Employee",
                3 => "Supplier",
                4 => "Distributor",
                _=> "No Case available"
            };
        }
    }
}
