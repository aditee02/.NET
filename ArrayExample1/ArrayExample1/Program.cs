using System;

namespace ArrayExample1
{
     class Program
    {
        static void Main()
        {
            //create an array
            int[] arr1= new int[5] {10,20,30,40,50};

            string[] arr2 = new string[] { "one", "two", "three", "four", "five" }; 

            //display the vales of elements
           for(int i=0;i<arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine();
           for(int i=0;i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }


           //foreach loop
           foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

           foreach(string str in arr2)
            {
                Console.WriteLine(str);
            }

           //reverse 
           for(int i=arr2.Length;i>0;i--) {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();


        }
    }
}
