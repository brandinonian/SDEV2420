using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollwithIndexers
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HireDate { get; set; }
        public Employee(string Id,
                        string FirstName,
                        string LastName,
                        int BirthMonth,
                        int BirthDay,
                        int BirthYear,
                        int HireMonth,
                        int HireDay,
                        int HireYear)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = new Date(BirthMonth, BirthDay, BirthYear);
            this.HireDate = new Date(HireMonth, HireDay, HireYear);
        }
        public override string ToString()
        {
            return $"Employee {Id}: {FirstName} {LastName}, birthdate {BirthDate}, hired {HireDate}";
        }
        public abstract decimal Earnings();
    }
}
