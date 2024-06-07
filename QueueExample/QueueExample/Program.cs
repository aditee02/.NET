using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main()
        {
            //create an object of queue class
            Queue<string> queue = new Queue<string>();


            //Enqueue (Add)
            queue.Enqueue("Task 3");
            queue.Enqueue("Task 5");
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 4");
            queue.Enqueue("Task 2");


            //foreach
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            //Dequeue
            string dq1 = queue.Dequeue();
            Console.WriteLine("Dequeue1 : "+dq1);

            string dq2 = queue.Dequeue();
            Console.WriteLine("Dequeue2 : "+dq2);

            //Peek
            string pk = queue.Dequeue();
            Console.WriteLine(":Peek : " + pk);

            //foreach
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
