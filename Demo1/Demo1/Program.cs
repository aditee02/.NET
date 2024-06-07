using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

abstract class Demo
{
    public abstract void demo_method1();
    public void demo_method2() { }
}

class Demo2 : Demo
{
    public override void demo_method1()
    {
        Console.WriteLine("Demo2 - demo_method1");
    }
    public 
    
}
class Demo3 : Demo2
{
    public override void demo_method2()
    {
        Console.WriteLine("Implemented ");
    }

}

class Program
{
    static void Main()
    {
        Demo2 obj = new Demo2();
        obj.demo_method1();
        Demo3 ob = new Demo3();
        ob.demo_method2 (); 
    }
}