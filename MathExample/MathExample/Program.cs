using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExample
{
    internal class Program
    {
        static void Main()
        {
            double a = Math.Pow(10, 4);//10 power 4
            double b = Math.Min(5.67, 10.657);
            double c = Math.Max(5.67, 10.657);
            double d = Math.Floor(20.32423);//returns the integer part
            double e = Math.Ceiling(20.32423);//returns the next integer
            double f = Math.Round(20.235345);//round up or round down
            double g = Math.Round(20.571212, 2);
            double i = Math.Sign(-10);// negative so -1
            double j = Math.Abs(-10);//returns positive number based on given negative number
            int rem;
            double quo = Math.DivRem(10, 3, out rem);
            double k = Math.Sqrt(25);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine("Quotient:" + quo + ",Remainder:" + rem);
            Console.WriteLine(Math.Floor(Convert.ToDouble(10) / 3));
            Console.WriteLine(10 % 3);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
