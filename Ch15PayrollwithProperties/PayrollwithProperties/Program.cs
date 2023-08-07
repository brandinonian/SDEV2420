using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PayrollwithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Payroll with Poperties by Brandon Phillips\n");

            // employees array
            Employee[] employees =
            {
                new SalariedEmployee("2233", "Bob", "Brooks", 100000M),
                new HourlyEmployee("1122", "Ann", "Adams", 20M, 55.5M),
                new SalariedEmployee("3344", "Cathy", "Clauson", 85000M),
                new HourlyEmployee("4455", "Doug", "Drummond", 45M, 22.5M)                
            };

            // loop through employees, display each and total the weekly earnings
            decimal totalWeeklyEarnings = 0;
            foreach (Employee employee in employees)
            {
                WriteLine(employee);
                totalWeeklyEarnings += employee.Earnings();
                WriteLine($"    weekly earnings: {employee.Earnings():C}");
            }

            // display total weekly earnings
            WriteLine($"\nTotal pay: {totalWeeklyEarnings:C}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
