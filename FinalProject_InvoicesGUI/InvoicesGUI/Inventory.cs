using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class Inventory {
        public int InventoryId { get; set; }
        public string ItemName { get; set; }
        public double ItemCost { get; set; }
        public Inventory(int InventoryId, string ItemName, double ItemCost) {
            this.InventoryId = InventoryId;
            this.ItemName = ItemName;
            this.ItemCost = ItemCost;
        }
    }
}
