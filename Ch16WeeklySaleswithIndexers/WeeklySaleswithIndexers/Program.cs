using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WeeklySaleswithIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeeklySales week1Sales = new WeeklySales();

            WriteLine("Weekly Sales with Indexers by Brandon Phillips\n");

            WriteLine("--- Enter Sales Numbers ---");
            string response = "n";
            do
            {
                Write("\nPlease enter the day: ");
                string inputDay = ReadLine();
                Write("Please enter the sales: $");
                double inputSales = double.Parse(ReadLine());
                week1Sales[inputDay] = inputSales;
                do
                {
                    Write("Enter more data? (Y/n)");
                    response = ReadLine().ToLower();
                } while (response != "n" && response != "y");

            } while (response == "y");

            // display each day spaced with \t
            WriteLine("\n" + week1Sales);

            WriteLine("\n--- Change Sales Numbers ---");
            do
            {
                Write("\nPlease enter the day: ");
                string inputDay = ReadLine();
                WriteLine($"Current sales = {week1Sales[inputDay]}");
                Write("Please enter the new sales: $");
                double inputSales = double.Parse(ReadLine());
                week1Sales[inputDay] = inputSales;
                do
                {
                    Write("Enter more changes? (Y/n)");
                    response = ReadLine().ToLower();
                } while (response != "n" && response != "y");
            } while (response == "y");

            // display each day again
            WriteLine("\n" + week1Sales);

            // calculate and display total sales
            double totalSales = 0;
            for (int i = 0; i < 5; i++)
            {
                totalSales += week1Sales[i];
            }
            WriteLine($"\nTotal Sales: {totalSales:C}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
