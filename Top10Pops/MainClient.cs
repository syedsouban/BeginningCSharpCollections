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



            Console.WriteLine("Enter batch size: ");

            int batchSize = int.Parse(Console.ReadLine());

            for (int i = 0;i < countries.Count;i++) {
                if (i>0 && i % batchSize == 0) {
                    Console.WriteLine("Press enter to continue printing countries and any other key to exit");
                    if (Console.ReadLine() != "") break;
                }
                if (countries[i] == null) break;

                Console.WriteLine($"{countries[i].Name} {countries[i].Population}");
            }
        }
    }
}
