using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollwithProperties
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(string Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public override string ToString()
        {
            return $"Employee {Id}: {FirstName} {LastName}";
        }
        public abstract decimal Earnings();
    }
}
