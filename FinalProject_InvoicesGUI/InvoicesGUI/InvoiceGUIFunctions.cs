using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class InvoiceGUIFunctions {

        // sort customers by last name for radio button
        public static List<Customer> SortCustomersByLastName(List<Customer> customers) {

            // list to hold results
            var list = new List<Customer>();

            // query to sort by last name
            var query =
                from customer in customers
                orderby customer.LastName
                select customer;

            // add each item to list
            foreach(var customer in query) {
                list.Add(customer);
            }

            // return list
            return list;
        }

        // sort customers by id
        public static List<Customer> SortCustomersById(List<Customer> customers) {

            // list to hold results
            var list = new List<Customer>();

            // query to sort by id
            var query =
                from customer in customers
                orderby customer.CustomerId
                select customer;

            // add each item to list
            foreach(var customer in query) {
                list.Add(customer);
            }

            // return list
            return list;
        }

        // sort inventory items by id
        public static List<Inventory> SortInventoryById(List<Inventory> inventory) {

            // list to hold results
            var list = new List<Inventory>();

            // query to sort by id
            var query =
                from item in inventory
                orderby item.InventoryId
                select item;

            // add each item to list
            foreach (var item in query) {
                list.Add(item);
            }

            // return list
            return list;
        }

        // sort inventory by cost
        public static List<Inventory> SortInventoryByCost(List<Inventory> inventory) {

            // list to hold results
            var list = new List<Inventory>();

            // query to sort by cost
            var query =
                from item in inventory
                orderby item.ItemCost
                select item;

            // add each item to list
            foreach(var item in query) {
                list.Add(item);
            }

            // return list
            return list;
        }

        // recursive fibonacci sequence
        public static long CalculateRecursively(long n) {
             // return fibonacci number
            if(n == 0 || n == 1) {
                return n;
            }
            else {
                return CalculateRecursively(n - 1) + CalculateRecursively(n - 2);
            }
        }
    }
}
