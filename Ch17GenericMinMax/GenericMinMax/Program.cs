using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMinMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            // hardcoded arrays
            int[] intArray = { 15, 29, 42, 18, 10, 23 };
            double[] doubleArray = { 43.2, 34.5, 78.9, 32.1, 55.6 };
            string[] stringArray = { "Tanya", "Julie", "Emily", "Sophie", "Haylee", "Andrea" };


            Console.WriteLine("Generic Min Max by Brandon Phillips\n");

            // display each array using generic method
            Console.Write("\nArray intArray contains: ");
            Display(intArray);
            Console.Write("\nArray doubleArray contains: ");
            Display(doubleArray);
            Console.Write("\nArray stringArray contains: ");
            Display(stringArray);
            Console.WriteLine();

            // display min and max for each array
            Console.Write("\nMinimum for intArray is: ");
            Console.Write(Minimum(intArray));
            Console.Write("\nMaximum for intArray is: ");
            Console.Write(Maximum(intArray));
            Console.WriteLine();

            Console.Write("\nMinimum for doubleArray is: ");
            Console.Write(Minimum(doubleArray));
            Console.Write("\nMaximum for doubleArray is: ");
            Console.Write(Maximum(doubleArray));
            Console.WriteLine();

            Console.Write("\nMinimum for stringArray is: ");
            Console.Write(Minimum(stringArray));
            Console.Write("\nMaximum for stringArray is: ");
            Console.Write(Maximum(stringArray));
            Console.WriteLine();


            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
        public static T Maximum<T>(T[] inputArray) where T : IComparable<T>
        {
            var max = inputArray[0]; // assume [0] is initially the largest

            foreach (var item in inputArray) // compare each item in the array to current max
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Minimum<T>(T[] inputArray) where T : IComparable<T>
        {
            var min = inputArray[0]; // assume [0] is initially the smallest

            foreach (var item in inputArray) // compare each item in the array to current min
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        private static void Display<T>(T[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write($"{item} "); 
            }
        }
    }
}
