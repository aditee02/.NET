

class Program
{
    static void Main()
    {
        //primitive variable
        int x = 10;

        //boxing (value - type to reference-type)
        object obj = x;

        System.Console.WriteLine(x);
        System.Console.WriteLine(obj);
        System.Console.ReadKey();
    }
}