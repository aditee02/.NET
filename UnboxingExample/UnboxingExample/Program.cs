
class Program
{
    static  void Main()
    {
        //reference type variable
        object obj = 10;

        //unboxing (reference type to value type)
        int x = (int)obj;

        System.Console.WriteLine(x);
        System.Console.WriteLine(obj);
        System.Console.ReadKey();
    }
}