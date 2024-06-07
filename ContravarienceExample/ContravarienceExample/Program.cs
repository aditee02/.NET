using System;
using System.Collections.Generic;

namespace ContravarienceExample
{

    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }
    
    class Parrot: LivingThing { }

    class Dog: LivingThing { }

    interface IMover<in T>
    {
        void Move(T x);
    }

    public class Mover<T>: IMover<T>
    {
        public void Move(T x)
        {
            if (x is Parrot)
            {
                Console.WriteLine("Moving with :" + (x as Parrot).NumberOfLegs + "Legs");
            }
            else
            {
                Console.WriteLine("Moving with :" + (x as Dog).NumberOfLegs + "Legs");
            }
        }
    }
     class Program
    {
        static void Main()
        {
            //create normal object
            Parrot parrot = new Parrot()
            {
                NumberOfLegs = 2
            };

            Dog dog = new Dog()
            {
                NumberOfLegs = 4
            };

            //Contravarience = supply the paranet type name,where the child type name is expected
            IMover<Parrot> obj1 = new Mover<Parrot>();//normal
            IMover<Parrot> obj2 = new Mover<LivingThing>();
            //"Parrot" vs "LivingThing" ;supplying the parent type<Living Thing) where the child type(Parrot) is expected
            obj2.Move(parrot);

            IMover<Dog> obj3 = new Mover<LivingThing>();
            obj3.Move(dog);

            Console.ReadKey();
        }
    }
}
