using System.Threading;

class Shared
{
    public static int SharedResources { get; set; } = 0;
    public static readonly object lockObject = new object();
}
class NumberUpCounter
{
    public int Count { get; set; }
    public void CountUp(Action<long> callback)
    {
        long sum = 0;
        try
        {

            Console.WriteLine("Count Up started");
            Thread.Sleep(1000);


            //i =  1 to count
            for (int i = 1; i <= Count; i++)
            {
                sum += i;
                Monitor.Enter(Shared.lockObject);//wait for lock gets opened
                Console.WriteLine($"Shared resource in Count up :{Shared.SharedResources}, ");//0
                Shared.SharedResources++;
                Monitor.Exit(Shared.lockObject); //close the lock
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
        finally
        {
            callback(sum);
        }
    }
}
class NumbersDownCounter
{
    public int Count { get; set; }
    public void CountDown(Object? count)
    {
        Console.WriteLine("Count Down started");
        Thread.Sleep(1000);


        //J = count TO 1
        for (int? j = Count; j >= 1; j--)
        {
            Monitor.Enter(Shared.lockObject);//wait fr the lock gets opened (acquired)
            Console.WriteLine($"Shared resource in Count down :{Shared.SharedResources}, ");//1

            Shared.SharedResources--;
            Monitor.Exit(Shared.lockObject);//Close(release) the lock 
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
        NumberUpCounter numberUpCounter = new NumberUpCounter() { Count = 100 };

        //Create callback method
        Action<long> callback = sum =>
        {
            Console.WriteLine($"\nReturn value from Count-Up  is: {sum}");
        };

        //create first thread
        ThreadStart threadStart1 = new ThreadStart(() =>
        {
            numberUpCounter.CountUp(callback);
        });
        Thread thread1 = new Thread(threadStart1)
        {
            Name = "Count-Up Thread",
            Priority = ThreadPriority.Highest
        };


        //Invoke CountUp
        thread1.Start();
        Console.WriteLine($"{thread1.Name}({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}");


        //object of NumberDownCounter
        NumbersDownCounter numberDownCounter = new NumbersDownCounter() { Count = 100 };

        //create second thread
        ParameterizedThreadStart threadStart2 = new ParameterizedThreadStart(
             numberDownCounter.CountDown);
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

        Console.WriteLine($"\nShared resources: {Shared.SharedResources}"); //Expected : 0

        Console.WriteLine(mainThread.Name + " completed");

        Console.ReadKey();
    }
}