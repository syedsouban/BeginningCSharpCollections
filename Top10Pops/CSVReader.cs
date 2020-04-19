using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BeginningCSCollections.Top10Pops
{
    class CSVReader
    {
        private string _csvFilePath;

        public CSVReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }
        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            try {
                using (var file = File.OpenText(_csvFilePath))
                {
                    string line = "";
                    string val = file.ReadLine();
                    int i = 0;
                    while ((line = file.ReadLine()) != null && i < nCountries)
                    {
                        String[] lineArr = line.Split(",");
                        int population = 0;
                        try
                        {
                            population = int.Parse(lineArr[3]);
                            
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine($"The country {lineArr[0]} does not have a proper integer population value msg: {f.Message} stacktrace:{f.StackTrace}");
                        }
                        countries[i] = new Country(lineArr[0], lineArr[1], lineArr[2], population);
                        i++;
                    }
                }
            }
            
            catch (IOException e) {
                Console.WriteLine($"File cannot be read! msg:{e.Message} stacktrace:{e.StackTrace}");
            }

            return countries;
        }

        
    }
}
