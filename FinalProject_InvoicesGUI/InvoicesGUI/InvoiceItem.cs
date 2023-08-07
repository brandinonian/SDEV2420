using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class InvoiceItem {
        public int InvoiceId {  get; set; }
        public int ItemNumber { get; set; }
        public int InventoryId { get; set; }
        public int QuantitySold { get; set; }
        public InvoiceItem(int InvoiceId, int ItemNumber, int InventoryId, int QuantitySold) { 
            this.InvoiceId = InvoiceId;
            this.ItemNumber = ItemNumber;
            this.InventoryId = InventoryId;
            this.QuantitySold = QuantitySold;
        }
    }
}
