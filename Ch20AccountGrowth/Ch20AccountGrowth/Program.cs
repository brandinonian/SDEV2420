using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch20AccountGrowth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Account Growth with Events by Brandon Phillips\n");

            // user input
            // starting balance
            Write("What is the starting balance? $");
            double balanceInput = double.Parse(ReadLine());

            // interest rate (input a whole integer then calculate percentage rate)
            Write("What is the interest rate? ");
            double interestInput = double.Parse(ReadLine());

            // number of cycles to grow the account
            Write("How many cycles to grow the account? ");
            int cyclesInput = int.Parse(ReadLine());


            // instantiate Account
            Account account = new Account(balanceInput, interestInput, cyclesInput);

            // subscribe to events
            account.OverOneHundred += NewAnnouncement;
            account.Doubled += NewAnnouncement;

            // display results
            account.Grow();


            WriteLine();
            WriteLine("Press any key to exit...");
            ReadKey();
        }

        public static void NewAnnouncement(string msg)
        {
            WriteLine(msg);
        }

    }
}
