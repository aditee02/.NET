using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Country.CountryName);
        Console.WriteLine(Country.NoOfStates);
        Console.WriteLine(Country.GetNoOfUnionTerritories());

        Console.ReadKey();
    }
}