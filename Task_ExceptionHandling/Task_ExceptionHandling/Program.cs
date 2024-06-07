using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
class UpCounter
{
    public long CountUp(int count,CancellationToken token)
    {
        long sum = 0;
        Console.WriteLine("\nCount-Up starts");
        for (int i = 1; i <= count; i++)
        {
            token.ThrowIfCancellationRequested();//throw new OperationCanceledException
            Console.Write($"{i}, ");
            sum += i;
            Task.Delay(300).Wait();
        }
        Console.WriteLine("\nCount-Up ends");
        //throw new Exception(
            //"Unable to generate sum in Count-Up method");
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
            Task.Delay(300).Wait();
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

        //create cancellationTokenSource class object(used to cancel a task)
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();



        //create and start taks
        Task.Run(() =>
        {
            return upCounter.CountUp(20,cancellationTokenSource.Token);
        },cancellationTokenSource.Token).ContinueWith((antecedent) =>
        {
            if(antecedent.Status == TaskStatus.Canceled){
                Console.WriteLine("Count-Up Task cancelled");
                return -1;
        }
            else if (antecedent.Status == TaskStatus.Faulted)
            {
                Console.WriteLine($"Exception occured {antecedent.Exception.InnerExceptions.First().Message}");
                return -1;
            }else if (antecedent.Status == TaskStatus.RanToCompletion)
                {
                return antecedent.Result;
            }
            else
            {
                return -1;
            }
        }).ContinueWith(antecedent =>
        {
            if (antecedent.Result != -1)
            {
                Console.WriteLine($"result from Count-Up {antecedent.Result}");
            }
        }); 

        Task.Factory.StartNew(() =>
        {
            return downCounter.CountDown(25);

        }).ContinueWith((antecedent) =>
        {
            Console.WriteLine($"Result from Count-Down:{antecedent.Result.Sum}");
        }); ;


        //create a new continuation task object that gets executed(starts automatically) when the antedent(preceding) task is completed(either successfully or with an exception)

        //create a new continuation task object that gets executed(starts automatically) when the antedent(preceding) task is completed(either successfully or with an exception)


        //task1.Wait();
        //task2.Wait();
        //        Task.WaitAll(task1, task2);
        /*
                int completedTaskIndex = Task.WaitAny(task1, task2);

                if (completedTaskIndex == 0)
                {
                    Console.WriteLine($"Result from Count-Up:{task1.Result}");
                }
                else
                {
                    Console.WriteLine($"Result from Count-Down:{task2.Result.Sum}");
                }
        */

        //cancel the task1
        Task.Delay(5000).Wait();
        cancellationTokenSource.Cancel();

        Console.WriteLine("End of Main Thread");

        //Sumdata s = task2.Result;
        Console.ReadKey();
    }

}

class SumData
{
    public long Sum { get; set; }
}