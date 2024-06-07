
using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        List<List<int>> lobj = new List<List<int>>(){
        new List<int>{67,100,23},
        new List<int>{80,99,750,99},
        new List<int>{888,333,9898}
    };

        List<int> largestList = Find(lobj);

        Console.WriteLine("Largest Number in each Collection");
        foreach (int i in largestList)
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }

    public static List<int> Find(List<List<int>> lobj)
    {
        List<int> largestList = new List<int>();

        foreach (List<int> list in lobj)
        {
            int max = int.MinValue;

            foreach (int x in list){
                if (x > max)
                {
                    max = x;
                }
            }
            largestList.Add(max);
        }
        return largestList;
    }
}
