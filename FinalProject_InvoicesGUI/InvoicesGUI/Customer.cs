using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesGUI {
    public class Customer {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
        public Customer(int CustomerId, string FirstName, string LastName) {
            this.CustomerId = CustomerId;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
