using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesGUI {
    public partial class InvoiceGUI : Form {
        public InvoiceGUI() {
            InitializeComponent();
        }

        // left hand display

        // sort customers by last name
        private void LastNameBtn_CheckedChanged(object sender, EventArgs e) {

            // only operate if the button is not already checked
            if(LastNameBtn.Checked) {

                // reset the text box
                LeftDisplay.Text = null;

                // sort customers by last name
                var list = InvoiceGUIFunctions.SortCustomersByLastName(InvoiceData.customerData);

                // display results
                foreach(var item in list) {
                    LeftDisplay.Text += $"{item.CustomerId}\t\t{item.LastName}, {item.FirstName}\n";
                }
            }
        }

        // sort customers by id
        private void CustIDBtn_CheckedChanged(object sender, EventArgs e) {

            // only operate if the button is not already checked
            if(CustIDBtn.Checked) {

                // reset the text box
                LeftDisplay.Text = null;

                // sort customers by id
                var list = InvoiceGUIFunctions.SortCustomersById(InvoiceData.customerData);

                // display results
                foreach(var item in list) {
                    LeftDisplay.Text += $"{item.CustomerId}\t\t{item.FullName}\n";
                }
            }
        }

        // sort inventory items by id
        private void InvIDBtn_CheckedChanged(object sender, EventArgs e) {

            // only operate if the button is not already checked
            if(InvIDBtn.Checked) {

                // reset the text box
                LeftDisplay.Text = null;

                // sort inventory items by id
                var list = InvoiceGUIFunctions.SortInventoryById(InvoiceData.inventoryData);

                // display results
                foreach(var item in list) {
                    LeftDisplay.Text += $"{item.InventoryId}\t{item.ItemName,-20}\t{item.ItemCost:C}\n";
                }
            }
        }

        // sort inventory items by cost
        private void CostBtn_CheckedChanged(object sender, EventArgs e) {

            // only operate if the button is not already checked
            if(CostBtn.Checked) {

                // reset text box
                LeftDisplay.Text = null;

                // sort inventory items by cost
                var list = InvoiceGUIFunctions.SortInventoryByCost(InvoiceData.inventoryData);

                // display results
                foreach(var item in list) {
                    LeftDisplay.Text += $"{item.ItemCost:C}\t{item.InventoryId}\t{item.ItemName}\n";
                }
            }
        }

        // right hand display

        // display invoices grouped by invoice number
        private async void InvoicesBtn_CheckedChanged(object sender, EventArgs e) {

            // only operate if the button is checked
            if(InvoicesBtn.Checked) {

                // reset the text box
                RightDisplay.Text = null;

                // fibonacci sequence to slow down processing
                long fib = await Task.Run(() => InvoiceGUIFunctions.CalculateRecursively(40));

                // output string
                string output = "Invoices\n\n";

                // track the total cost
                double totalCost = 0;

                // join invoices and customers
                var invoiceList =
                    from invoice in InvoiceData.invoiceData
                    join customer in InvoiceData.customerData on invoice.CustomerId equals customer.CustomerId
                    select new { invoice.InvoiceId, customer.CustomerId, customer.FullName, invoice.Date };

                // add invoices to output
                foreach(var invoice in invoiceList) {

                    // track invoice total
                    double invoiceTotal = 0;

                    output += $"Invoice {invoice.InvoiceId}" +
                        $"\nCustomer {invoice.CustomerId} {invoice.FullName}\t\tDate {invoice.Date}";

                    // add each line item to output with calculated cost
                    var lineItemList =
                        from item in InvoiceData.invoiceItemData
                        where item.InvoiceId == invoice.InvoiceId
                        join inventory in InvoiceData.inventoryData on item.InventoryId equals inventory.InventoryId
                        select new { item.ItemNumber, inventory.ItemName, inventory.ItemCost, item.QuantitySold };

                    // add each line item to ouput
                    foreach(var item in lineItemList) {

                        // calculate item cost
                        double invoiceCost = item.QuantitySold * item.ItemCost;

                        // update totals
                        invoiceTotal += invoiceCost;
                        totalCost += invoiceCost;

                        // add item to output
                        output += $"\n{item.ItemNumber} {item.ItemName}\t\t@ {item.ItemCost:C}\t\tqty sold {item.QuantitySold,-4}\tcost {invoiceCost:C}";
                    }

                    // add total cost to output string
                    output += $"\nTotal for invoice: {invoiceTotal:C}\n\n";
                }

                // output total for all invoices
                output += $"\nGrand Total: {totalCost:C}";

                // display results in text box
                RightDisplay.Text = output;
            }
        }

        // display inventory items sold, sorted by inventory id
        private async void InventorySoldBtn_CheckedChanged(object sender, EventArgs e) {

            if(InventorySoldBtn.Checked) {
                // reset text box
                RightDisplay.Text = null;

                // fibonacci sequence to slow down processing
                long fib = await Task.Run(() => InvoiceGUIFunctions.CalculateRecursively(40));

                // output string
                string output = "Inventory Changes\n";

                // join inventory and invoice data
                var inventoryList =
                    from item in InvoiceData.invoiceItemData
                    join inventory in InvoiceData.inventoryData on item.InventoryId equals inventory.InventoryId
                    select new { item.InventoryId, item.InvoiceId, item.QuantitySold, inventory.ItemCost };

                // group by inventory id
                var groupedInventoryList =
                    from item in inventoryList
                    group item by item.InventoryId into gr
                    orderby gr.Key
                    select gr;

                // add items to output string
                foreach(var gr in groupedInventoryList) {

                    // track the total for each item
                    double itemTotal = 0;

                    // update output string
                    output += $"\nInventory Item {gr.Key}";

                    // add each invoice to output string
                    foreach(var item in gr) {
                        // calculate invoice cost
                        double invoiceCost = item.ItemCost * item.QuantitySold;

                        // track item total
                        itemTotal += invoiceCost;

                        // update output string
                        output += $"\n\tInvoice {item.InvoiceId}\tsold {item.QuantitySold}\tcost {invoiceCost:C}";
                    }

                    // add itemTotal to output string
                    output += $"\nTotal sold: {itemTotal:C}\n";
                }

                // display output string
                RightDisplay.Text = output; 
            }
        }

        // display invoice totals grouped by customer
        private async void InvoicesByCustomerBtn_CheckedChanged(object sender, EventArgs e) {

            if(InvoicesByCustomerBtn.Checked) {

                // reset text box
                RightDisplay.Text = null;

                // fibonacci sequence to slow down processing
                long fib = await Task.Run(() => InvoiceGUIFunctions.CalculateRecursively(40));

                // output string
                string output = "Invoices sorted by Customer\n";

                // track total cost
                double totalCost = 0;

                // join invoices and line items
                var invoiceList =
                    from item in InvoiceData.invoiceItemData
                    join invoice in InvoiceData.invoiceData on item.InvoiceId equals invoice.InvoiceId
                    join inventory in InvoiceData.inventoryData on item.InventoryId equals inventory.InventoryId
                    select new { item.InvoiceId, item.InventoryId, invoice.CustomerId, item.QuantitySold, inventory.ItemCost };

                // group items by customer
                var groupedInvoiceList =
                    from item in invoiceList
                    group item by item.CustomerId into gr
                    orderby gr.Key
                    select gr;

                // display each group
                foreach(var gr in groupedInvoiceList) {

                    // update output string
                    output += $"\nCustomer {gr.Key}";

                    // group by invoice
                    var groupedInvoices =
                        from item in gr
                        group item by item.InvoiceId into g
                        select g;

                    // calculate invoice cost and update output string
                    foreach(var g in groupedInvoices) {

                        // track invoice total
                        double invoiceTotal = 0;

                        // calculate total
                        foreach(var i in g) {
                            invoiceTotal += i.ItemCost * i.QuantitySold;
                        }

                        // update total Cost
                        totalCost += invoiceTotal;

                        // update output string
                        output += $"\n\tInvoice {g.Key}\t\tTotal: {invoiceTotal:C}";
                    }
                }

                // add grand total to output string
                output += $"\n\nTotal: {totalCost:C}";

                // display results
                RightDisplay.Text += output; 
            }
        }
    }
}
