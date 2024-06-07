
class Program
{
    static void Main()
    {
        //create an object of car class
        Car c = new Car();

        //call get accessor of indexer
        System.Console.WriteLine(c[0]);//output : bmw

        //call set accessor of index
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]);//output: Nissan

        System.Console.ReadKey();
    }
}