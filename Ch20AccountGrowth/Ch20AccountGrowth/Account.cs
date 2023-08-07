using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20AccountGrowth
{
    public class Account
    {
        public double StartingBalance { get; set; }

        public double InterestRate { get; set; }

        public int NumberOfCycles { get; set; }

        public Account() { }

        public Account(double startingBalance, double interestRate, int numberOfCycles)
        {
            StartingBalance = startingBalance;
            InterestRate = interestRate / 100; // convert whole number rate to percent
            NumberOfCycles = numberOfCycles;
        }

        public delegate void AnnouncementHandler(string msg);

        public event AnnouncementHandler OverOneHundred;
        public event AnnouncementHandler Doubled;

        public void Grow()
        {
            double balance = StartingBalance;
            for (int i = 0; i < NumberOfCycles; i++)
            {
                double interest = balance * InterestRate;
                balance += interest;

                // make announcements if the balance exceeds 100 or doubles
                if (balance >= 100)
                {
                    OverOneHundred?.Invoke("** Balance exceeded $100");
                    OverOneHundred = null;
                }
                if (balance >= (StartingBalance * 2))
                {
                    Doubled?.Invoke("** Balance has doubled");
                    Doubled = null;
                }

                // void method, display each cycle in the console
                Console.WriteLine($"In cycle {i}, Account has balance of {balance:C}");
            }
        }
    }
}
