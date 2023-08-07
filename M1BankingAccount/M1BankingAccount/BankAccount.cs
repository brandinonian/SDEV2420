using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace M1BankingAccount
{
    public class BankAccount
    {
        private int _balance;
        public double Balance
        {
            get
            {
                return (double)_balance / 100;
            }
            set
            {
                _balance = (int)(value * 100);
            }
        }
        private int _fee;
        public double Fee
        {
            get
            {
                return (double)_fee / 100;
            }
            set
            {
                _fee = (int)(value * 100);
            }
        }
        public BankAccount()
        {
            Balance = 0;
            Fee = 0;
        }

        public BankAccount(double Balance, double Fee)
        {
            this.Balance = Balance;
            this.Fee = Fee;
        }

        public void Withdraw(double amount)
        {
            
            if ((amount + Fee) <= Balance)
            {
                Balance -= (amount + Fee);
                Console.WriteLine($"Account has balance {Balance:C}, fee {Fee:C}");
            }
            else
            {
                Console.WriteLine("Not enough funds for that withdrawal");
            }
        }
        public void Deposit(double amount)
        {
            
            Balance += amount - Fee;
            Console.WriteLine($"Account has balance {Balance:C}, fee {Fee:C}");
        }

        public void Display()
        {
            Console.WriteLine($"Balance: {Balance:C}, Fee: {Fee:C}");
        }
    }
}
