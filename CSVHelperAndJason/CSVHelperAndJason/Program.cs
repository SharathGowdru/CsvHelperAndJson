using System;

namespace CSVHelperAndJason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from csv file and Write data in to csv files");
            CSVHandler.ImplementCSVDataHandling();
            Console.WriteLine();

            Console.WriteLine("Read data from csv and write that data into Json file");
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.WriteLine();
        }
    }
}
