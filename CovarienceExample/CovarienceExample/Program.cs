using System;
using System.Collections.Generic;

namespace CovarienceExample
{
    class LivingThing
    {
        public int NumberOfLegs {  get; set; } 
    }
    class Parrot : LivingThing
    {

    }
    class Dog : LivingThing
    {

    }
    interface IMover<out T>
    {
        T Move();
    }
    class Mover<T> : IMover<T>
    {
        public T thing { get; set; }
        public T Move()
        {
            return thing;
        }


    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values) { 
        foreach(var item in values)
            {
                Console.WriteLine(item+" ");
            }
        Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            //create object
            LivingThing livingThing = new Parrot();//not covarience
            Parrot parrot = new Parrot()
            {
                NumberOfLegs = 2
            };//normal

            //covarience - supply the child type name,wher the parent type name is expected
            IMover<LivingThing> mover =
                new Mover<Parrot>()
                {
                    thing = parrot
                };
            Console.WriteLine("Moving with " + mover.Move().NumberOfLegs + " legs");//supplying the child type(Parrot), where the parent type (Living Thing) is expected

            //covarience in real life
            Sample s = new Sample();
            s.PrintValues(new List<string>() { "hello", "world" });

            Console.ReadKey(); 
        }
    }
}
