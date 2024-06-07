using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;//System.Text.StringBuilder

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main()
        {
            string[] words = new string[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

            //expected output: the quick brown fox jumps over hthe lazy dog
            string sentence = "";
            foreach(string word in words)
            {
                sentence = sentence+" "+ word;//problem : new object will be created for each iteration
                                              ////1 st iteration : "the"
                                              ///2 nd iteration : "The quick"
                                              /////..
                                              ///
            }
            //StringBuilder
            StringBuilder builder = new StringBuilder("hello",20);
            foreach(string word in words)
            {
                builder.Append(word);
                builder.Append(" ");

                Console.WriteLine(builder.ToString()+","+builder.Length+","+builder.Capacity);
             }
            builder[0] = 'v';
            Console.WriteLine(builder.ToString());
            Console.WriteLine(builder.MaxCapacity);

            Console.WriteLine(builder.Insert(5, "updated"));
            Console.WriteLine(builder.Remove(builder.ToString().IndexOf("q"), 5));
            Console.WriteLine(builder.Replace("a", "r"));
            Console.ReadKey();
        }
    }
}
