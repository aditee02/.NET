using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
class UpCounter
{
    public long CountUp(int count)
    {
        long sum = 0;
        Console.WriteLine("\nCount-Up starts");
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"{i}, ");
            sum += i;
        }
        Console.WriteLine("\nCount-Up ends");
        return sum;
    }
}
class DownCounter
{
    public SumData CountDown(int count)
    {
        long sum = 0;
        Console.WriteLine("\nCount-Down starts");
        for (int j = count; j >= 1; j--)
        {
            Console.Write($"{j}, ");
            sum += j;
        }
        Console.WriteLine("\nCount-Down ends");
        return new SumData() { Sum = sum };
    }
}

class Program
{
    static void Main()
    {
        //create objects for counter class
        UpCounter upCounter = new UpCounter();
        DownCounter downCounter = new DownCounter();

        //create and start taks
        Task<long> task1 = Task.Factory.StartNew(() =>
        {
            return upCounter.CountUp(20);
        });

        Task<SumData> task2 = Task.Factory.StartNew(() =>
        {
            return downCounter.CountDown(25);

        });
        //task1.Wait();
        //task2.Wait();
        //        Task.WaitAll(task1, task2);

        int completedTaskIndex = Task.WaitAny(task1, task2);

        if(completedTaskIndex == 0)
        {
            Console.WriteLine($"Result from Count-Up:{task1.Result}");
        }else
        {
            Console.WriteLine($"Result from Count-Down:{task2.Result.Sum}");
        }

        //Console.WriteLine($"Result from Count-Up:{task1.Result}");
        //Console.WriteLine($"Result from Count-Down :{task2.Result.Sum}");

        //Sumdata s = task2.Result;
        Console.ReadKey();
    }

}

class SumData
{
    public long Sum { get; set; }
}