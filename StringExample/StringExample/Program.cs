using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExample
{
    internal class Program
    {
        static void Main()
        {
            string str = "Developer";
            Console.WriteLine(str);
            string str_upr = str.ToUpper();
            Console.WriteLine(str_upr);
            string str_lwr = str.ToLower();
            Console.WriteLine(str_lwr);
            string str_sub = str.Substring(4);
            Console.WriteLine(str_sub);
            string str_sub2 = str.Substring(4, 3);
            Console.WriteLine(str_sub2);

            string str_rpl = str.Replace("e", "a");
            Console.WriteLine(str_rpl);

            string messege = "how are you";
            string[] words = messege.Split(' ');
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            string messege_with_spaces = " hello ";
            string str_trm = messege_with_spaces.Trim();
            Console.WriteLine("Trim : " + str_trm);

            char[] characters = str.ToCharArray();
            Console.WriteLine("\n Characters:");
            foreach(char ch in characters)
            {
                Console.WriteLine(ch);
            }

            string[] my_words = new string[] { "how", "are", "you" };
            string str_in = string.Join("-", my_words);
            Console.WriteLine("Join:" + str_in);

            char[] characters2 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(characters2);
            Console.WriteLine("New strig:" + str2);

            string str3 = "universe";
            string str4 = "universe";

            bool eq = str.Equals(str2);
            bool eq2 = str == str2;

            Console.WriteLine("Equals : " + eq);
            Console.WriteLine("==:"+eq2);

            bool sw = str.StartsWith("u");
            Console.WriteLine("StartsWith:" + str);
            bool sw2 = str.StartsWith("e");
            Console.WriteLine("StartWith:" + sw2);

            bool ew = str.EndsWith("e");
            bool ew2 = str.EndsWith("u");
            Console.WriteLine("Ends with:" + ew);
            Console.WriteLine("Ends with:" + ew2);

            bool ct = str.Contains("e");
            bool ct2 = str.Contains("t");
            Console.WriteLine("Contains: " + ct);
            Console.WriteLine("Contains: " + ct2);

            string name = "developer";
            int ind1 = name.IndexOf("e");
            int ind2 = name.IndexOf("vel");
            int ind3 = name.IndexOf("gel");
            int ind4 = name.IndexOf("e",2);
            int ind5 = name.IndexOf("e",4);
            Console.WriteLine("Index of e:" + ind1);
            Console.WriteLine("Index of vel:" + ind2);
            Console.WriteLine("Index of gel:" + ind3);
            Console.WriteLine("Index of e,2:" + ind4);
            Console.WriteLine("Index of e,4:" + ind5);

            int ind6 = name.LastIndexOf("e");
            int ind7 = name.LastIndexOf("vel");
            int ind8 = name.LastIndexOf("gel");
            int ind9 = name.LastIndexOf("e",2);
            int ind10 = name.LastIndexOf("e",4);
            Console.WriteLine("LastIndexOs of e:" + ind6);
            Console.WriteLine("LastIndexOs of vel:" +
             ind7);
            Console.WriteLine("LastIndexOs of gel:" + ind8);
            Console.WriteLine("LastIndexOs of e,2:" + ind9);
            Console.WriteLine("LastIndexOs of e,4:" + ind10);

            string user_input = null;
            string user_input2 = "";
            string user_input3 = " ";
            bool noe1 = string.IsNullOrEmpty(user_input);
            bool noe2 = string.IsNullOrEmpty(user_input2);
            bool noe3 = string.IsNullOrEmpty(user_input3);
            Console.WriteLine("IsNullOrEmpty: " + noe1);
            Console.WriteLine("IsNullOrEmpty: " + noe2);
            Console.WriteLine("IsNullOrEmpty: " + noe3);

            bool now1 = string.IsNullOrWhiteSpace(user_input);
            bool now2 = string.IsNullOrWhiteSpace(user_input2);
            bool now3 = string.IsNullOrWhiteSpace(user_input3);
            Console.WriteLine("IsNullOrEmpty: " + now1);
            Console.WriteLine("IsNullOrEmpty: " + now2);
            Console.WriteLine("IsNullOrEmpty: " + now3);

            string director = "Sam Raimi", movie = "Spider man";
            string messege1 = string.Format("{0} is the director of {1}", director, movie);
            string messege2 = $"{director} is the director of {movie}";

            Console.WriteLine(messege1);
            Console.WriteLine(messege2);

            string name1 = "Developer";
            string name_updated = name1.Insert(4, "sad");
            Console.WriteLine(name_updated);

            string name_updated2 = name.Remove(2, 4);
            Console.WriteLine(name_updated2);

            string name3 = "developer@example.com";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;
            for(int i = 0; i < name3.Length; i++)
            {
                bool isMatch = false;
                for(int j = 0; j < vowels.Length; j++)
                {
                    if (name3[i] == vowels[j])
                        isMatch = true;

                    if (isMatch)
                    {
                        vowelsCount++;
                    }    }
                    Console.WriteLine(name3[i] + " " + isMatch);
                
            }
             
            Console.WriteLine(vowelsCount + "vowels count");

            //using methods of arrays/collections
            vowelsCount = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (Array.IndexOf(vowels, name[i]) >= 0)
                    vowelsCount++;

            }
            Console.WriteLine(vowelsCount + "vowels found");

            //using LINQ
            Console.WriteLine(name.Count(ch => Array.IndexOf(vowels, ch) >= 0));
            
            Console.ReadKey();

        }
    }
}
