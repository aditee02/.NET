
class UpCounter
{
    public void CountUp(int count)
    {
        Console.WriteLine("\nCount-Up Starts");
        for(int i = 1; i <= count; i++)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        Console.WriteLine("\nCount-Up Ends");
    }
}

class DownCounter
{
    public void CountDown(int count)
    {
        Console.WriteLine("\nCount-Down Starts");
        for(int j = count; j >= 1; j--)
        {
            Console.Write($"{j}, ");
        }
        Console.WriteLine();
        Console.WriteLine("\nCount-Down Ends");
    }
}

class Program
{
    static void Main()
    {
        //create objects for counter class
        UpCounter upCounter = new UpCounter();
        DownCounter downCounter = new DownCounter();

        //create and start task
        Task task1 = Task.Run(() =>
        {
            upCounter.CountUp(20);
        });

        Task task2 = Task.Run(() =>
        {
            downCounter.CountDown(20);
        });

        Console.ReadKey();
    }
}
