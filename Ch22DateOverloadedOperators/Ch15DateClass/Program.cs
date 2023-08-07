using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Date Class by Brandon Phillips");

            // user input for month, day, and year
            WriteLine("\nStart with a good date");
            Write("Enter the month number: ");
            int inputMonth = int.Parse(ReadLine());
            Write("Enter the day number: ");
            int inputDay = int.Parse(ReadLine());
            Write("Enter the year number: ");
            int inputYear = int.Parse(ReadLine());

            // create and display date
            Date inputDate = new Date(inputMonth, inputDay, inputYear);
            WriteLine($"This date is: {inputDate}");

            // Ask user how many days to add using operator overload
            Write("How many days to add using operator overload? ");
            int inputOperatorDays = int.Parse(ReadLine());
            inputDate = inputDate + inputOperatorDays;
            WriteLine($"Result of adding {inputOperatorDays} days to the date: {inputDate}");

            // Ask user how many days to add using compound assignment
            Write("How many days to add using compound assignment? ");
            int inputCompoundDays = int.Parse(ReadLine());
            inputDate += inputCompoundDays;
            WriteLine($"Using compound assignment, result of adding {inputCompoundDays} days is: {inputDate}");

            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
