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

            WriteLine("Use a good date");
            Date theDate = new Date(4, 19, 2019);
            WriteLine(theDate);

            WriteLine("\nUse invalid year of 1700");
            theDate = new Date(4, 19, 1700);
            WriteLine(theDate);

            WriteLine("\nUse invalid month of 17");
            theDate = new Date(17, 19, 2019);
            WriteLine(theDate);

            WriteLine("\nUse invalid day for month of 4");
            theDate = new Date(4, 31, 2019);
            WriteLine(theDate);

            WriteLine("\nUse invalid day of 319");
            theDate = new Date(4, 319, 2019);
            WriteLine(theDate);

            WriteLine("\nTry 2-digit year");
            theDate = new Date(4, 20, 19);
            WriteLine(theDate);

            WriteLine("\nStart with 4/19/19 and add 5 days");
            theDate = new Date(4, 19, 2019);
            for (int i = 0; i < 5; i++)
            {
                theDate.IncrementDay();
            }

            WriteLine("\nStart with 2/27/19 and add 5 days");
            theDate = new Date(2, 27, 2019);
            for (int i = 0; i < 5; i++)
            {
                theDate.IncrementDay();
            }

            WriteLine("\nStart with 2/27/12 and add 5 days");
            theDate = new Date(2, 27, 2012);
            for (int i = 0; i < 5; i++)
            {
                theDate.IncrementDay();
            }

            WriteLine("\nStart with 9/29/19 and add 5 days");
            theDate = new Date(9, 29, 2019);
            for (int i = 0; i < 5; i++)
            {
                theDate.IncrementDay();
            }

            WriteLine("\nStart with 12/29/2019 and add 5 days");
            theDate = new Date(12, 29, 2019);
            for (int i = 0; i < 5; i++)
            {
                theDate.IncrementDay();
            }

            WriteLine("\nPress any key to exit...");
            ReadKey();

        }
    }
}
