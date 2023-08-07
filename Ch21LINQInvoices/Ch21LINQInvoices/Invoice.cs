using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch21LINQInvoices
{
    public class Invoice
    {
        public string Id {get; set;}

        public int CustomerId { get; set;}

        public Date Date { get; set;}

        public double Amount { get; set;}

        public Invoice(string Id, int CustomerId, Date Date, double Amount)
        {
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.Date = Date;
            this.Amount = Amount;
        }
    }
}
