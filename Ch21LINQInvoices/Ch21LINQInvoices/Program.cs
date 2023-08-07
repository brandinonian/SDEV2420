using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch21LINQInvoices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("LINQ Invoices by Brandon Phillips");

            // create customers list
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(543, "Acme Services"));
            customers.Add(new Customer(298, "Ajax Computers"));
            customers.Add(new Customer(715, "Clarke Support"));
            customers.Add(new Customer(601, "Master PCs"));

            // create inovices list
            List<Invoice> invoices = new List<Invoice>();
            invoices.Add(new Invoice("W78", 543, new Date(5, 8, 2019), 532.20));
            invoices.Add(new Invoice("S89", 543, new Date(7, 1, 2019), 120.00));
            invoices.Add(new Invoice("W24", 543, new Date(1, 20, 2019), 750.00));
            invoices.Add(new Invoice("W55", 298, new Date(7, 15, 2018), 451.50));
            invoices.Add(new Invoice("R16", 298, new Date(4, 30, 2018), 475.75));
            invoices.Add(new Invoice("R91", 298, new Date(8, 12, 2018), 308.50));
            invoices.Add(new Invoice("S60", 715, new Date(10, 30, 2018), 312.50));
            invoices.Add(new Invoice("R54", 715, new Date(6, 24, 2019), 240.50));
            invoices.Add(new Invoice("W43", 601, new Date(11, 17, 2018), 215.00));
            invoices.Add(new Invoice("S91", 601, new Date(2, 19, 2019), 185.50));

            // sort customers by id
            WriteLine("\n--- Customers sorted by Id ---");

            var customersById =
                from customer in customers
                orderby customer.Id
                select customer;

            foreach (var customer in customersById)
                WriteLine($"{customer.Id} {customer.Name}");

            // sort customers by name
            WriteLine("\n--- Customers sorted by Name ---");

            var customersByName =
                from customer in customers
                orderby customer.Name
                select customer;

            foreach (var customer in customersByName)
                WriteLine($"{customer.Id} {customer.Name}");

            // sort invoices by id
            WriteLine("\n--- Invoices sorted by Id ---");

            var invoicesById =
                from invoice in invoices
                orderby invoice.Id
                select invoice;

            foreach (var invoice in invoicesById)
                WriteLine($"Invoice {invoice.Id}\tCustomer {invoice.CustomerId}\t{invoice.Date}\t{invoice.Amount:C}");


            // lists all invoices grouped by customer, groups sorted by customer id, with totals for each customer and grand total
            WriteLine("\n--- List invoices grouped by customer ---");

            double grandTotal = 0;

            var invoicesByCustomer =
                from invoice in invoices
                join customer in customers
                on invoice.CustomerId equals customer.Id
                group new { invoice.Id, invoice.Date, invoice.Amount, invoice.CustomerId } by invoice.CustomerId into custGroup
                orderby custGroup.Key
                select custGroup;

            foreach (var group in invoicesByCustomer)
            {
                double customerTotal = 0;

                WriteLine($"\nCustomer {group.Key}");
                foreach (var invoice in group)
                {
                    WriteLine($"   {invoice.Id}, {invoice.Date}, {invoice.Amount:C}");
                    customerTotal += invoice.Amount;
                }
                WriteLine($"Total for customer: {customerTotal:C}");

                grandTotal += customerTotal;
            }

            // total all invoices
            WriteLine("\n--- Grand Total ---");
            WriteLine($"    {grandTotal:C}");

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}
