using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PayrollwithIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Payroll with Poperties by Brandon Phillips\n");

            // employees array
            Employee[] employees =
            {
                new HourlyEmployee("1122", "Ann", "Adams", 20M, 55.5M, 10, 19, 1990, 8, 1, 2012),
                new SalariedEmployee("2233", "Bob", "Brooks", 100000M, 11, 11, 1992, 4, 12, 2020),
                new SalariedEmployee("3344", "Cathy", "Clauson", 85000M, 1, 5, 1987, 11, 15, 2012),
                new HourlyEmployee("4455", "Doug", "Drummond", 45M, 22.5M, 2, 18, 1993, 1, 15, 2019),
                new SalariedEmployee("2244", "Brandon", "Phillips", 60000M, 6, 10, 1996, 4, 1, 2022),
                new HourlyEmployee("3366", "Gavin", "Kent", 32M, 38.75M, 10, 10, 1995, 4, 20, 2020)
            };

            // loop through employees and display each
            foreach (Employee employee in employees)
                WriteLine(employee);

            // loop through employees, display the birth/hire dates for each
            WriteLine();
            foreach (Employee employee in employees)
            {
                WriteLine($"Employee {employee.Id}: Birth Month {employee.BirthDate["mo"]}, " +
                    $"Hire Month/Year {employee.HireDate["mo"]}/{employee.HireDate["yr"]}");
            }

            // loop through employees, check for matching birthday month and hire month to apply bonuses
            WriteLine();
            decimal totalWeeklyEarnings = 0;
            foreach (Employee employee in employees)
            {
                string output = $"{employee.Id} : weekly earnings:";
                decimal bonus = 0;
                if (employee.BirthDate["mo"] == 10) // hardcoded data for testing
                {
                    bonus += 250;
                    output += " Birthday month, bonus $250 ";
                }
                if (employee.HireDate["mo"] == 4) // hardcoded data for testing
                {
                    bonus += 500;
                    output += " Anniversary month, bonus $500 ";
                }
                decimal netPay = employee.Earnings() + bonus;
                totalWeeklyEarnings += netPay;
                output += $" {netPay:C}";
                WriteLine(output);
            }

            // display total weekly earnings
            WriteLine($"\nTotal pay: {totalWeeklyEarnings:C}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
