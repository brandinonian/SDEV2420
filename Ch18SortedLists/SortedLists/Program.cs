using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted Lists by Brandon Phillips\n");

            SortedList<string, int> itemList = new SortedList<string, int>();

            bool repeat = false;
            do
            {
                Console.Write("\nEnter product ID (integer): ");
                int inputId = int.Parse(Console.ReadLine());
                Console.Write("Enter product name: ");
                string inputName = Console.ReadLine();
                itemList.Add(inputName, inputId);

                // display each item in itemList
                Console.WriteLine();
                foreach (KeyValuePair<string, int> kvp in itemList)
                {
                    Console.WriteLine($"{kvp.Value} {kvp.Key}");
                }

                // ask user to add another
                string reply = "";
                while (reply != "y" && reply != "n")
                {
                    Console.Write("\nAny more to add? (Y/n): ");
                    reply = Console.ReadLine().ToLower();
                    if (reply == "y")
                        repeat = true;
                    else if (reply == "n")
                        repeat = false;
                }
            } while (repeat);


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
