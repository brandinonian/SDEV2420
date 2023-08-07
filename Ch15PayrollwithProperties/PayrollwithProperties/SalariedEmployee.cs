using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollwithProperties
{
    public class SalariedEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalariedEmployee(string Id, string FirstName, string LastName, decimal Salary):base(Id, FirstName, LastName)
        {
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, salaried, {Salary:C} annual";
        }
        public override decimal Earnings() { return Salary / 52; }
    }
}
