
using System;
class PinValidation
{
    static void Main()
    {
        try
        {
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin.ToString().Length < 4 && pin.ToString().Length > 6)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("valid");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid");
        }
        Console.ReadKey();
    }
}
