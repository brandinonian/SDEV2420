using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21LINQPayroll
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal HourlyRate { get; set; }

        public Employee(int id, string firstName, string lastName, decimal hourlyRate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
        }
    }
}
