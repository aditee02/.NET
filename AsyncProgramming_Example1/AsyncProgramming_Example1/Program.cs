using System.IO;
using System.Threading.Tasks;

class FileWriter
{
    public async Task WriteFile(string fileName, string data)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            //Task writerTask = writer.WriteAsync(data);
            await writer.WriteAsync(data);
        }
    }
}

class FileReader
{
    public async Task<string> ReadFile(string fileName)
    {
        throw new NotSupportedException();
        using (StreamReader reader = new StreamReader(fileName))
        {
            //Task<string> readerTask = reader.ReadToEndAsync();

            string content = await reader.ReadToEndAsync();
            return content;
        }
    }
}

class Program
{
    public async static Task Main()
    {
        //Initialize 
        string fileName = @"C:\vs code\C#\India.txt";
        FileWriter fileWriter = new FileWriter();
        FileReader fileReader = new FileReader();

        //write data to a file asynchronously
        await fileWriter.WriteFile(fileName, "India is the most populous country by 2023");//block the current task (but without blocking the current thread
        Console.WriteLine("File written");

        try
        {
            //Read data from the file asynchrnously
            string content = await fileReader.ReadFile(fileName);
            //Block the current thread until the read operation is complete
            Console.WriteLine("File read.");
            Console.WriteLine($"\n File content:{content}");

        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}

