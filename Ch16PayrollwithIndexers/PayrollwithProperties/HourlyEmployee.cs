using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollwithIndexers
{
    public class HourlyEmployee : Employee
    {
        public decimal Hours { get; set; }
        public decimal HourlyPay { get; set; }
        public HourlyEmployee(string Id,
                              string FirstName,
                              string LastName,
                              decimal Hours,
                              decimal HourlyPay,
                              int BirthMonth,
                              int BirthDay,
                              int BirthYear,
                              int HireMonth,
                              int HireDay,
                              int HireYear) : base(Id,
                                                   FirstName,
                                                   LastName,
                                                   BirthMonth,
                                                   BirthDay,
                                                   BirthYear,
                                                   HireMonth,
                                                   HireDay,
                                                   HireYear)
        {
            this.Hours = Hours;
            this.HourlyPay = HourlyPay;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, hourly, wage {HourlyPay:C}, hours worked: {Hours:0.0}";
        }
        public override decimal Earnings()
        {
            if (Hours > 40M)
                return (40M * HourlyPay) + ((Hours - 40M) * (HourlyPay * 1.5M));
            else return (Hours * HourlyPay);
        }
    }
}
