using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch21LINQPayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("LINQ Payroll by Brandon Phillips");

            // create list of employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1234, "David", "Dawson", 12.50M));
            employees.Add(new Employee(4321, "Ann", "Adams", 10.50M));
            employees.Add(new Employee(3456, "Ella", "Emerson", 10.00M));
            employees.Add(new Employee(6543, "Gary", "Gray", 11.00M));
            employees.Add(new Employee(7890, "Bob", "Brooks", 15.00M));
            employees.Add(new Employee(9870, "Cathy", "Clarke", 15.00M));
            employees.Add(new Employee(5561, "Sam", "Stamp", 9.50M));
            employees.Add(new Employee(6712, "Mary", "Lamb", 13.50M));

            // create list of hours worked
            List<HoursWorked> hoursWorked = new List<HoursWorked>();
            hoursWorked.Add(new HoursWorked(1234, 8.0, 7.5, 7.5, 8.0, 8.0));
            hoursWorked.Add(new HoursWorked(4321, 6.5, 8.5, 7.5, 6.0, 6.0));
            hoursWorked.Add(new HoursWorked(3456, 6.0, 7.5, 6.5, 8.0, 7.0));
            hoursWorked.Add(new HoursWorked(6543, 8.0, 8.0, 8.0, 8.0, 8.0));
            hoursWorked.Add(new HoursWorked(7890, 8.5, 8.0, 8.0, 7.5, 7.0));
            hoursWorked.Add(new HoursWorked(9870, 9.0, 8.0, 7.0, 6.0, 8.0));
            hoursWorked.Add(new HoursWorked(5561, 7.0, 7.5, 7.5, 8.0, 7.5));
            hoursWorked.Add(new HoursWorked(6712, 8.0, 7.5, 8.5, 8.0, 8.0));

            // sort employees by descending hourly rate (highest to lowest)
            var sortedEmployees =
                from employee in employees
                orderby employee.HourlyRate descending
                select employee;

            // print sorted employees with id, first and last, and hourly rate
            WriteLine("\nEmployees sorted by hourly rate");
            WriteLine($"\nId           Name       Hourly Rate");

            foreach (var employee in sortedEmployees)
                WriteLine($"{employee.Id} {employee.FirstName,10} {employee.LastName,-10} {employee.HourlyRate,6:C}");

            // combine the two tables, add the hours for each employee, sort results based on total hours
            var totalHoursList =
                from employee in employees
                join hours in hoursWorked
                on employee.Id equals hours.Id
                orderby (hours.MondayHours + hours.TuesdayHours + hours.WednesdayHours + hours.ThursdayHours + hours.FridayHours) descending
                select new
                {
                    employee.Id,
                    employee.FirstName,
                    employee.LastName,
                    employee.HourlyRate,
                    totalHours = (hours.MondayHours + hours.TuesdayHours + hours.WednesdayHours + hours.ThursdayHours + hours.FridayHours)
                };

            // display each employee id, first and last, hourly rate, and total hours
            WriteLine("\nEmployees sorted by total hours");
            WriteLine("\nId           Name       Hourly Rate    Hours");

            foreach (var employee in totalHoursList)
                WriteLine($"{employee.Id} {employee.FirstName,10} {employee.LastName,-10} {employee.HourlyRate,6:C} {employee.totalHours,10:.00}");

            // combine the employee table with previous result, calculate total pay and order by employee id
            // add each to a running total
            decimal grandTotalPay = 0;
            var totalPayList =
                from employee in employees
                join hours in totalHoursList
                on employee.Id equals hours.Id
                orderby employee.Id
                select new
                {
                    employee.Id,
                    employee.HourlyRate,
                    hours.totalHours,
                    totalPay = (employee.HourlyRate * (decimal)hours.totalHours)
                };

            // display each employee with total hours and total pay, sorted by id
            WriteLine("\nEmployees total hours and total pay");
            WriteLine("\nId    Hourly Rate    Hours    Total Pay");

            foreach (var employee in totalPayList)
            {
                WriteLine($"{employee.Id, -8} {employee.HourlyRate,6:C} {employee.totalHours,10:.00} {employee.totalPay,10:C}");
                grandTotalPay += employee.totalPay;
            }

            // display grand total pay
            WriteLine($"\nTotal Pay for all Employees: {grandTotalPay:C}");


            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
