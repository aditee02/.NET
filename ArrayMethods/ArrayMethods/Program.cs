using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] arr = new int[] {10, 20,50, 30, 40,30 };

            //search for 30 in the array
            int n = Array.IndexOf(arr, 30);

            Console.WriteLine("30 is found at : "+n);

            //search for 30 in the array(second occurance)
            int m = Array.IndexOf(arr, 30, 3);
            Console.WriteLine("30 second occurance is found at : " + m);
            //searchh for 100 in the array(not exists)
            int n3 = Array.IndexOf(arr, 100);
            Console.WriteLine("100 is fund at : "+n3);


            Console.WriteLine("--------------");
            int n4 = Array.BinarySearch(arr, 30);

            Console.WriteLine("30 is found at : " + n4);
            int n5 = Array.BinarySearch(arr, 100);
            Console.WriteLine("100 is found at : " + n5);

            Console.WriteLine("-----------------");
            //Array.Clear(arr, 0, arr.Length);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");
            Array.Resize(ref arr, 4);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
