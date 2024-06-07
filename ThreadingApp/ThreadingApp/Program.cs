using System.Text;
class Program
{
    static void Main()
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";

        ThreadPriority priority = mainThread.Priority;//priority of the thread Lowest | BelowNormal | Normal | AboveNormal | Hoigest
        Console.WriteLine(mainThread.Name);//main thread
        Console.WriteLine(priority.ToString());//Normal
        Console.WriteLine(mainThread.IsAlive);//True(whether the thread started or not)
        Console.WriteLine(mainThread.IsBackground);//False(whether the thread is a background thread or not)
        ThreadState state = mainThread.ThreadState;//Unstarted /  Running/ WaitSleepJoin etc.
        Console.WriteLine(state.ToString());//Running
        Console.ReadKey();
    }
}