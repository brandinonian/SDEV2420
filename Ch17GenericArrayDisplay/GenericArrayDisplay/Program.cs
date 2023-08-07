using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Array Display by Brandon Phillips\n");

            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'W', 'O', 'R', 'L', 'D' };

            Console.WriteLine($"Array intArray contains: {DisplayArray(intArray)}");
            Console.WriteLine($"Array doubleArray contains: {DisplayArray(doubleArray)}");
            Console.WriteLine($"Array stringArray contains: {DisplayArray(charArray)}");
            Console.WriteLine();

            // user input
            int lowIndex = 0;
            int highIndex = 0;
            try
            {
                Console.Write("\nEnter a low index: ");
                lowIndex = int.Parse(Console.ReadLine());

                Console.Write("Enter a high index: ");
                highIndex = int.Parse(Console.ReadLine());

                // do not allow low index to be less than 0
                if (lowIndex < 0)
                {
                    lowIndex = 0;
                    throw new Exception("Low index cannot be less than 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //
            //
            // intArray display
            try
            {
                if (highIndex > intArray.Length)
                    throw new ArgumentOutOfRangeException();
                Console.WriteLine($"intArray range [{lowIndex}:{highIndex}] contains: " +
                    $"{DisplayArray(intArray, lowIndex, highIndex)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nintArray {ex.Message}");
            }

            //
            //
            // doubleArray display
            try
            {
                if (highIndex > doubleArray.Length)
                    throw new ArgumentOutOfRangeException();
                Console.WriteLine($"doubleArray range [{lowIndex}:{highIndex}] contains: " +
                    $"{DisplayArray(doubleArray, lowIndex, highIndex)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\ndoubleArray {ex.Message}");
            }

            //
            //
            // charArray display
            try
            {
                if (highIndex > charArray.Length)
                    throw new ArgumentOutOfRangeException();
                Console.WriteLine($"charArray range [{lowIndex}:{highIndex}] contains: " +
                    $"{DisplayArray(charArray, lowIndex, highIndex)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\ncharArray {ex.Message}");
            }

            Console.WriteLine();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static string DisplayArray<T>(T[] inputArray)
        {
            string outputString = "";
            foreach (var element in inputArray)
            {
                outputString += $"{element} ";
            }
            return outputString;
        }

        private static string DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            string outputString = "";
            for (int i = lowIndex; i <= highIndex; i++)
            {
                outputString += $"{inputArray[i]} ";
            }
            return outputString;
        }
    }
}
