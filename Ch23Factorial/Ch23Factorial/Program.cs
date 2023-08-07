using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch23Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 23 Factorial by Brandon Phillips");

            //WriteLine("\nInvoke 3 sequential methods");

            //CalcFirst();

            //CalcSecond();

            //CalcThird();

            WriteLine("\nInvoke 3 parallel methods");

            Parallel.Invoke(CalcFirst, CalcSecond, CalcThird);

            WriteLine("\nIn Main, after calls to calculate");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }

        public static void Factorial(int number)
        {
            long result = 1;
            for (int k = number; k > 1; k--)
                result *= k;
            WriteLine($"\nInside Factorial method, Factorial of {number} is {result:N}");
        }

        public static void CalcFirst()
        {
            WriteLine("\nEntered CalcFirst");
            Factorial(10);
            WriteLine("\nInside CalcFirst, factorial of 10 is complete");
        }

        public static void CalcSecond()
        {
            WriteLine("\nEntered CalcSecond");
            Factorial(12);
            WriteLine("\nInside CalcSecond, factorial of 12 is complete");
        }

        public static void CalcThird()
        {
            WriteLine("\nEntered CalcThird");
            Factorial(20);
            WriteLine("\nInside CalcThird, factorial of 20 is complete");
        }
    }
}
