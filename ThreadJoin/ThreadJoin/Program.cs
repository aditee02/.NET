using System.Threading;


class NumberCounter
{
    public void CountUp()
    {
        Console.WriteLine("Count Up started");
        Thread.Sleep(1000);

        //i =  1 to 100
        for (int i = 1; i <= 100; i++)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"i = {i}, ");
            Thread.Sleep(100);//1000 milliseconds = 1 sec
        }
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine("Count Up completed");
    }
    public void CountDown()
    {
        Console.WriteLine("Count Down started");
        Thread.Sleep(1000);

        //J = 100 TO 1
        for (int j = 100; j >= 1; j--)
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
        Console.WriteLine(mainThread.Name+" started");// Main Thread

        //object of NumberCounter
        NumberCounter numberCounter = new NumberCounter();

        //create first thread
        ThreadStart threadStart1 = new ThreadStart(numberCounter.CountUp);
        Thread thread1 = new Thread(threadStart1)
        {
            Name = "Count-Up Thread",
            Priority = ThreadPriority.Highest
        };  

        //Invoke CountUp
        thread1.Start();
        Console.WriteLine($"{thread1.Name}({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}");

        //create second thread
        ThreadStart threadStart2 = new ThreadStart(numberCounter.CountDown);
        Thread thread2 = new Thread(threadStart2)
        {
            Name = "Count-Down Thread",
             Priority = ThreadPriority.BelowNormal
    };
        
        //Invoke CountUp
        thread2.Start();
        Console.WriteLine($"{thread2.Name}({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}");

        //Join
        thread1.Join();
        thread2.Join();

        Console.WriteLine(mainThread.Name + " completed");

        Console.ReadKey();
    }
}