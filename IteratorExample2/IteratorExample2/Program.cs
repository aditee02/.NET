using System;
using System.Collections.Generic;

namespace IteratorExample2
{
    public class Sample
    {
        public IEnumerable<int> Method()
        {
            Console.WriteLine("Iterator method executes");
            yield return 10;
            Console.WriteLine("Iterator method executes continued");
            yield return 20;
        }
    }
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            var enumerable1 = s.Method();
            var enumerator1 = enumerable1.GetEnumerator();
           
            foreach(var item in enumerable1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
