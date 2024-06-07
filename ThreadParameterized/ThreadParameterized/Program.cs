using System.Threading;

class MaxCount
{
    public int Count { get; set; } 
}

class NumberCounter
{
    public void CountUp(Object? count)
    {
        try
        {

            Console.WriteLine("Count Up started");
            Thread.Sleep(1000);

            MaxCount? maxCount = (MaxCount?)count;
            if (maxCount == null)
            {
                return;
            }

            //i =  1 to count
            for (int i = 1; i <= maxCount.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"i = {i}, ");
                Thread.Sleep(100);//1000 milliseconds = 1 sec
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Count Up completed");

        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine("Count-Up Thread interrupted");
        }
    }
    public void CountDown(Object? count)
    {
        Console.WriteLine("Count Down started");
        Thread.Sleep(1000);

        //j = count to 1
        MaxCount? maxCount = (MaxCount?)count;
        if(maxCount == null)
        {
            return;
        }

        //J = count TO 1
        for (int? j = maxCount.Count; j >= 1; j--)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"j = {j}, ");
            Thread.Sleep(100);//1000 milliseconds = 1 sec
        }
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine("Count Down completed");
    }
}
class Program
{
    static void Main()
    {
        //Get main thread
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";
        Console.WriteLine(mainThread.Name + " started");// Main Thread

        //object of NumberCounter
        NumberCounter numberCounter = new NumberCounter();

        //create first thread
        ParameterizedThreadStart threadStart1 = new ParameterizedThreadStart(
            numberCounter.CountUp);
        Thread thread1 = new Thread(threadStart1)
        {
            Name = "Count-Up Thread",
            Priority = ThreadPriority.Highest
        };

        //Invoke CountUp
        MaxCount maxCount1 = new MaxCount() { Count = 100 };
        thread1.Start(maxCount1);
        Console.WriteLine($"{thread1.Name}({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}");

        //create second thread
        ParameterizedThreadStart threadStart2 = new ParameterizedThreadStart(
             numberCounter.CountDown);
        Thread thread2 = new Thread(threadStart2)
        {
            Name = "Count-Down Thread",
            Priority = ThreadPriority.BelowNormal
        };

        //Invoke CountUp
        MaxCount maxCount2 = new MaxCount() { Count = 100 };
        thread2.Start(maxCount2);
        Console.WriteLine($"{thread2.Name}({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}");

        //Join
        thread1.Join();
        thread2.Join();

        Console.WriteLine(mainThread.Name + " completed");

        Console.ReadKey();
    }
}