using System;

class Program
{
    static void Main()
    {

        string[] names = new string[3];

        names[0] = "Alice";
        names[1] = "Bob";
        names[2] = "Charlie";

        foreach(string str in names){
            Console.WriteLine(str);
        }
    }
}