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
            List<Country> countries = reader.ReadAllCountries();
            foreach (var country in countries) {
                if (country == null) break;
                Console.WriteLine($"{country.Name} {country.Population}");
            }
        }
    }
}
