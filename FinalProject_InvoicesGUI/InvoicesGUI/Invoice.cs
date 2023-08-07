using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class Invoice {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public Date Date { get; set; }
        public Invoice(int InvoiceId, int CustomerId, int Month, int Day, int Year) {
            this.InvoiceId = InvoiceId;
            this.CustomerId = CustomerId;
            this.Date = new Date(Month, Day, Year);
        }
    }
}
