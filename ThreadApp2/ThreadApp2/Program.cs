using System.Threading;


class NumberCounter
{
    public void CountUp()
    {
        //i =  1 to 100
        for (int i = 1; i <= 100; i++)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"i = {i}, ");
            Thread.Sleep(1000);//1000 milliseconds = 1 sec
        }
        Console.WriteLine();
    }
    public void CountDown()
    {
        //J = 100 TO 1
        for (int j = 100; j >=1; j--)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"j = {j}, ");
            Thread.Sleep(1000);//1000 milliseconds = 1 sec
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        //Get main thread
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";
        Console.WriteLine(mainThread.Name);// Main Thread

        //object of NumberCounter
        NumberCounter numberCounter = new NumberCounter();

        //create first thread
        ThreadStart threadStart1 = new ThreadStart(numberCounter.CountUp);
        Thread thread1 = new Thread(threadStart1);
        thread1.Name = "Count-Up Thread";
        Console.WriteLine($"Thread 1 is {thread1.ThreadState.ToString()}");//Unstarted

        //Invoke CountUp
        thread1.Start();
        Console.WriteLine($"Thread 1 is {thread1.ThreadState.ToString()}");//Running

        //create second thread
        ThreadStart threadStart2 = new ThreadStart(numberCounter.CountDown);
        Thread thread2 = new Thread(threadStart2);
        thread2.Name = "Count-Down Thread";
        Console.WriteLine($"Thread 2 is {thread2.ThreadState.ToString()}");//Unstarted

        //Invoke CountUp
        thread2.Start();
        Console.WriteLine($"Thread 2 is {thread2.ThreadState.ToString()}");//Running

        Console.WriteLine(mainThread.Name + " completed");

        Console.ReadKey();
    }
}