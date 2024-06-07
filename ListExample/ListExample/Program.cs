using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ListExample
{
    internal class Program
    {
        static void Main()
        {
            //create reference variable for List class and create object of List class
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop");
            foreach(int item in myList)
            {
                Console.WriteLine(item); // output: 10 20 30
            }

            Console.WriteLine("Using for lop");
            for(int i=0;i<myList.Count;i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine("-----------");
            //Add method
            //add new element at the end of existing collection
            myList.Add(40);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 20 30 40
            }
           
            Console.WriteLine("-----------");
            //AddRange Method
            List<int> otherList = new List<int> { 50, 60, 70 };
            myList.AddRange(otherList);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 20 30 40 50 60 70
            }
            Console.WriteLine("-----------");
            //Insert Method
            myList.Insert(1, 15);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 15 20 30 40 50 60 70
            }
            Console.WriteLine("-----------");
            //InsertRange Method
            myList.InsertRange(1, otherList);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 50 60 70 15 20 30 40 50 60 70
            }

            Console.WriteLine("-----------");
            //remove method
            myList.Remove(30);
            myList.InsertRange(1, otherList);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 50 60 70 15 20  40 50 60 70
            }
            Console.WriteLine("-----------");
            //RemoveAt()
            myList.RemoveAt(2);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 10 50 70 15 20  40 50 60 70
            }
            Console.WriteLine("-----------");
            //RemoveRange
            //arguments - starting index, no of elements to remove
            myList.RemoveRange(0, 3);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output:  15 20  40 50 60 70
            }
            Console.WriteLine("-----------");
            //RemoveAll()
            myList.RemoveAll(value => value > 50);
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output:  15 20  40 50
            }
            Console.WriteLine("-----------");
            //Clear()
            myList.Clear();
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output:  
            }
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            Console.WriteLine("-----------");
            //IndexOf
            //parameters - value,startIndex
            Console.WriteLine(myList.IndexOf(40)); // 3
            Console.WriteLine(myList.IndexOf(60)); //-1
            Console.WriteLine("-----------");
            //BinarySearch()
            //requires the collection which is sorted
            int n1 = myList.BinarySearch(40);
            Console.WriteLine("Binary Search of 40: " + n1);
            Console.WriteLine("-----------");
            //Contains -- returns true/false
            Console.WriteLine(myList.Contains(100)); //False

            Console.WriteLine("-----------");
            //Sort 
            //by default ascending order sorting
            myList.Sort();
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output:  10 20 30 40 50
            }
            Console.WriteLine("-----------");
            myList.Reverse();// -- sort in descending order
            foreach (int item in myList)
            {
                Console.WriteLine(item); // output: 50 40 30 20 10  
            }

            Console.WriteLine("-----------");
            //ToArray()
            List<string> myFriends = new List<string> { "Scott", "Allen", "James", "Jones" };

            //convert to array
            string[] myFriendsArray = myFriends.ToArray();

            foreach(string item in myFriendsArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            //ForEach method
            myFriends.ForEach(friend  => Console.WriteLine(friend));
            Console.WriteLine("-----------");
            List<int> marks = new List<int> { 40, 95, 23, 15, 88 };

            //check if the student is failed 
            bool b = marks.Exists(m => m < 35);
            if (b == true)
            {
                Console.WriteLine("Student is failed in one or more subjects");
            }
            else
            {
                Console.WriteLine("Student is Pass");
            }
            Console.WriteLine("-----------");
            //Find()
            //get marks of first failed subject
            int firstFailedmarks = marks.Find(m => m < 35);
            Console.WriteLine("First Failed Marks : " + firstFailedmarks);
            Console.WriteLine("-----------");
            //FindIndex
            int firstFailedmarksIndex = marks.FindIndex(m => m < 35);
            Console.WriteLine("First Failed Marks Index : " + firstFailedmarksIndex);
            Console.WriteLine("-----------");
            //FindLast
            int LastFailedmarks = marks.FindLast(m => m < 35);
            Console.WriteLine("Last Failed Marks  : " + LastFailedmarks);
            Console.WriteLine("-----------");
            //FindLastIndex
            int LastFailedmarksIndex = marks.FindLastIndex(m => m < 35);
            Console.WriteLine("Last Failed Marks Index : " + LastFailedmarksIndex);
            Console.WriteLine("-----------");
            //FindAll : Get all failed subjects mark
            List<int> allFailedMarks = marks.FindAll(m => m < 35);
            Console.WriteLine("Failed Marks : ");
            foreach(int item in allFailedMarks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");

            //create source allocation
            List<int> intCollection = new List<int> { 1, 8, 2, 7 };

            //read each value into lambda expression; convert the same value u=into string
            List<string> strCollection =intCollection.ConvertAll<string>((n) =>
            {
                string word;
                switch(n){
                    case 1:word = "one";break;
                    case 2: word = "two"; break;
                    case 3: word = "three"; break;
                    case 4: word = "four"; break;
                    case 5: word = "five"; break;
                    case 6: word = "six"; break;
                    case 7: word = "seven"; break;
                    case 8: word = "eight"; break;
                    case 9: word = "nine"; break;
                    default: word = ""; break;
                }
                return word;
            }); 

            //print the result 
            foreach(string item in strCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
           

            Console.ReadKey();
        }
    }
}
