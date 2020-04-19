using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCSCollections.Top10Pops
{
    class Program
    {
        static void Main(String[] a) {
            string filePath = @"C:\Users\Souban\Downloads\csharp-collections-beginning\Pop_by_Largest_Final.csv";
            CSVReader reader = new CSVReader(filePath);
            Dictionary<string,Country> countries = reader.ReadAllCountries();
            Console.WriteLine("Enter a country code to get information about it: ");
            var countryCode = Console.ReadLine();
            if (countries.ContainsKey(countryCode))
            {
                var country = countries[countryCode];
                Console.WriteLine($"Information about {countryCode}: \nName:{country.Name}\nRegion:{country.Region}\nPopulation:{country.Population}");
            }
            else {
                Console.WriteLine("There is no country with the given code");
            }
        }
    }
}
