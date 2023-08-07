using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3CompetencyProject
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double HourlyRate { get; set; }

        public string Department { get; set; }

        public Date HireDate { get; set; }

        public Date FullHireDate { get; set; }

        public Employee(int Id, string FirstName, string LastName, double HourlyRate, string Department, int Month, int Day, int Year)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.HourlyRate = HourlyRate;
            this.Department = Department;
            this.HireDate = new Date(Month, Day, Year);
            this.FullHireDate = new Date(Month, Day, Year) + 90; // (HireDate + 90) here also increments HireDate, unintended behavior
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {HourlyRate} {Department} {HireDate}";
        }

        public string DisplayFullHireDate()
        {
            return $"{Id} hired on {HireDate}, probation done {FullHireDate}";
        }
    }
}
