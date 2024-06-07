using System;
using System.Runtime.InteropServices;

namespace MultiDiamentionalArray
{
    internal class Program
    {
        static void Main()
        {
            //multi dim array 4x3
            int[,] arr = new int[4, 3]
            {
                {10,20,30 },
                { 40,60,70},
                {80,90,100 },
                { 110,120,130}
            };

            //read data from multi-dim array
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------");

            //jagged array
            int[][] a = new int[3][];
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[5] { 40, 50, 60, 70, 80 };
            a[2] = new int[2] { 90,100 };

            //read jagged array
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < a[i].Length
                    ; i++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
