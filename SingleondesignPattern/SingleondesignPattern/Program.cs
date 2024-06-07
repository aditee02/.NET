using System;

class Singleton
{

    static Singleton obj = new Singleton();

    private Singleton()
    {
        Console.WriteLine("Coonstructor");
    }

    public static Singleton getObject()
    {
        return obj;
    }
}

class Program
{

    public static void Main()
    {

        Singleton obj1 = Singleton.getObject();
        Console.WriteLine(obj1.GetHashCode());

        Singleton obj2 = Singleton.getObject();
        Console.WriteLine(obj2.GetHashCode());

        Singleton obj3 = Singleton.getObject();
        Console.WriteLine(obj3.GetHashCode());
    }
}
