using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch21LINQLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("LINQ Letters by Brandon Phillips");

            // create a new list of random characters
            List<char> chars = ListGenerator.NewList();

            // display the full list
            WriteLine("\nChar List:");

            foreach (char c in chars)            
                Write($"{c} ");
            
            WriteLine();

            // sort into ascending list
            var ascendingList =
                from c in chars
                orderby c
                select c;

            // display ascending order list
            WriteLine("\nAscending Order List:");

            foreach (char c in ascendingList)
                Write($"{c} ");

            WriteLine();

            // sort into ascending order, no duplicates
            var uniqueAscendingList = ascendingList.Distinct();               

            // display ascending order, no duplicates
            WriteLine("\nAscending Order, No Duplicates:");

            foreach (char c in uniqueAscendingList)
                Write($"{c} ");

            WriteLine();

            // sort into descending order
            var descendingList =
                from c in chars
                orderby c descending
                select c;

            // display descending order
            WriteLine("\nDescending Order List:");

            foreach (char c in descendingList)
                Write($"{c} ");

            WriteLine();

            // sort into descending order, no duplicates
            var uniqueDescendingList = descendingList.Distinct();

            // sort into descending order, no duplicates
            WriteLine("\nDescending Order List, no duplicates:");

            foreach (char c in uniqueDescendingList)
                Write($"{c} ");

            WriteLine();

            // calculate number of unique letters
            int uniqueLetters = chars.Distinct().Count();

            // display number of unique letters
            WriteLine($"\nUnique Letters: {uniqueLetters}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
