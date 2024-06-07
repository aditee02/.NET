using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerializationExample
{
    [Serializable]
    public class Continent
    {
        public string ContinentName { get; set; }
        public List<Country> Countries { get; set; }
    }


    [Serializable]
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

    }
    class Program
    {
        static void Main()
        {
            //create data
            List<Continent> continents = new List<Continent>();
            continents.Add(new Continent()
            {
                ContinentName = "Africa",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 1,CountryName = "Sudan"},
                    new Country(){CountryID = 2,CountryName = "Libya"},
                    new Country(){CountryID = 3,CountryName = "South Africa"},
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "Asia",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 4,CountryName = "Russia"},
                    new Country(){CountryID = 5,CountryName = "China"},
                    new Country(){CountryID = 6,CountryName = "India"},
                }
            });


            continents.Add(new Continent()
            {
                ContinentName = "Euroape",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 7,CountryName = "Germany"},
                    new Country(){CountryID = 8,CountryName = "Ukrain"},
                    new Country(){CountryID = 9,CountryName = "France"},
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "North Ameriaca",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 10,CountryName = "Canada"},
                    new Country(){CountryID = 11,CountryName = "United States"},
                    new Country(){CountryID = 12,CountryName = "Maxico"},
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "South Ameriaca",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 13,CountryName = "Brazil"},
                    new Country(){CountryID = 14,CountryName = "Argentina"},
                    new Country(){CountryID = 15,CountryName = "Peru"},
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "Asia",
                Countries = new List<Country>()
                {
                    new Country(){CountryID = 4,CountryName = "Russia"},
                    new Country(){CountryID = 5,CountryName = "China"},
                    new Country(){CountryID = 6,CountryName = "India"},
                }
            });

            Country country = new Country() { CountryID = 1, CountryName = "United States" };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Continent>));
            string filePath = @"c:\practice\continents.xml";

            //Serialize
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, continents);
            fileStream.Close();
            Console.WriteLine("continents" +
                ".xml created");

            //Deserialize
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            List<Continent> continents_from_file = xmlSerializer.Deserialize(fileStream2) as List<Continent>;
            Console.WriteLine("\ncontinents.xml deserialized:");
            foreach (Continent cont in continents)
            {
                Console.WriteLine(cont.ContinentName);
                foreach (Country country1 in cont.Countries)
                {
                    Console.Write(country1.CountryName + ",");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
