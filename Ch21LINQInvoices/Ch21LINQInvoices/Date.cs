using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21LINQInvoices
{
    public class Date
    {
        public int day;

        public int month;

        public int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
