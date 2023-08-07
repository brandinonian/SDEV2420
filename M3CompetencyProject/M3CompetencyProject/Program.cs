using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace M3CompetencyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Payroll with LINQ and Operator Overloading by Brandon Phillips");

            // instantiate data
            // employees
            Employee[] employees =
            {
                new Employee(1234, "David", "Dawson", 12.50, "HR", 3, 16, 2018),
                new Employee(4321, "Ann", "Adams", 10.50, "IT", 4, 20, 2018),
                new Employee(3456, "Ella", "Emerson", 10.00, "SA", 8, 28, 2016),
                new Employee(6543, "Gary", "Gray", 11.00, "HR", 10, 15, 2015),
                new Employee(7890, "Bob", "Brooks", 15.00, "IT", 1, 15, 2015),
                new Employee(9870, "Cathy", "Clarke", 15.00, "IT", 9, 1, 2018),
                new Employee(5561, "Sam", "Stamp", 9.50, "SA", 7, 6, 2017),
                new Employee(6712, "Brandon", "Phillips", 13.50, "IT", 5, 20, 2017)
            };

            // hoursworked
            HoursWorked[] hoursWorked =
            {
                new HoursWorked(1234, 8.0, 7.5, 7.5, 8.0, 8.0),
                new HoursWorked(4321, 6.5, 8.5, 7.5, 6.0, 6.0),
                new HoursWorked(3456, 6.0, 7.5, 6.5, 8.0, 7.0),
                new HoursWorked(6543, 8.0, 8.0, 8.0, 8.0, 8.0),
                new HoursWorked(7890, 8.5, 8.0, 8.0, 7.5, 7.0),
                new HoursWorked(9870, 9.0, 8.0, 7.0, 6.0, 8.0),
                new HoursWorked(5561, 7.0, 7.5, 7.5, 8.0, 7.5),
                new HoursWorked(6712, 8.0, 7.5, 8.5, 8.0, 8.0),
            };

            // department
            Department[] departments =
            {
                new Department("Human Resources", "HR"),
                new Department("Information Technology", "IT"),
                new Department("Sales", "SA")
            };

            WriteLine();

            WriteLine("Count Employees and Departments");

            WriteLine();

            // count the number of employees
            int employeeCount = employees.Count();


            WriteLine($"There are {employeeCount} employees");

            // count the number of departments
            var departmentCount = departments.Count();

            WriteLine($"There are {departmentCount} departments");

            // join employees and departments, display ID and full name, department name, sorted by department
            var employeeJoinToDept =
                from department in departments
                join employee in employees on department.Abbreviation equals employee.Department
                orderby department.DeptName
                select new { employee.Id, employee.FirstName, employee.LastName, department.DeptName };

            WriteLine();

            WriteLine("List employees by department");

            foreach (var employee in employeeJoinToDept)
            {
                WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}, from {employee.DeptName}");
            }

            WriteLine();

            WriteLine("Employees with Hire and Probation Dates");

            // display employee id, hire date, and full hire date with a method
            foreach (var employee in employees)
            {
                WriteLine(employee.DisplayFullHireDate());
            }

            // group employee by department
            var employeesByDept =
                from employee in employees
                group employee by employee.Department into gr
                select gr;

            WriteLine();

            WriteLine("Employees grouped by Department");

            foreach (var dept in employeesByDept)
            {
                WriteLine();

                WriteLine($"Dept = {dept.Key}");

                foreach (var employee in dept)
                {
                    WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}");
                }
            }

            WriteLine();

            WriteLine("Display workers total hours and total pay, sorted by dept");

            // calculate total hours worked by each employee, sort results by department (display department, emp id, rate, total hours, individual pay)
            // accumulate total pay and display
            double grandTotalPay = 0;
            var employeeTotalHours =
                from employee in employees
                join hours in hoursWorked on employee.Id equals hours.Id
                orderby employee.Department
                select new { employee.Id, employee.Department, employee.HourlyRate, TotalHours = hours.GetTotalHours(), IndividualPay = hours.GetTotalHours() * employee.HourlyRate };

            foreach (var e in employeeTotalHours) // TODO: Somehow I'm missing Gary?
            {
                WriteLine($"{e.Department}: {e.Id}, rate {e.HourlyRate:C}: total hours {e.TotalHours}: total pay {e.IndividualPay:C}");
                grandTotalPay += e.IndividualPay;
            }

            WriteLine($"Total Pay for all Employees: {grandTotalPay:C}");

            WriteLine();

            // use the previous result, group results by department
            // display each department with employees (include pay for each, then accumulate into totals for each department, then the overall total again)
            double deptGrandTotalPay = 0;
            var deptTotalHours =
                from employee in employeeTotalHours
                group employee by employee.Department into gr
                select gr;

            foreach (var dept in deptTotalHours)
            {
                WriteLine($"Department: {dept.Key}");

                double deptTotalPay = 0;

                foreach(var employee in dept)
                {
                    deptTotalPay += employee.IndividualPay;
                    WriteLine($"{employee.Id}, total pay {employee.IndividualPay:C}");
                }
                deptGrandTotalPay += deptTotalPay;

                WriteLine($"Total department pay: {deptTotalPay:C}");

                WriteLine();
            }

            WriteLine($"Total pay for all Departments: {deptGrandTotalPay:C}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
