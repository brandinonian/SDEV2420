using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1BankingAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Module 1 - Banking Account by Brandon Phillips");

            Console.WriteLine("\nSet up the account");

            Console.Write("\nWhat is the starting balane? ");
            double startingBalance = double.Parse(Console.ReadLine());
            Console.Write("What is the fee for this account? ");
            double startingFee = double.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(startingBalance, startingFee);


            bool repeat = false;
            do
            {
                string reply = "";
                string userQuit = "";
                Console.Write("\nW to withdraw, D to deposit, B to see balance, Q to quit: ");
                reply = Console.ReadLine().ToLower();

                switch (reply)
                {
                    case "w":
                        Console.Write("\nHow much to withdraw? ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case "d":
                        Console.Write("\nHow much to deposit? ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case "b":
                        account.Display();
                        break;
                    case "q":
                        userQuit = "n"; // skips the "more transactions" input
                        repeat = false; // exits input loop
                        break;
                    default:
                        userQuit = "y"; // skips the "more transactions" input
                        repeat = true; // restarts input loop
                        break;
                }

                while (userQuit != "y" && userQuit != "n")
                {
                    Console.Write("\nDo you have more transactions? (Y/n) ");
                    userQuit = Console.ReadLine();
                    if (userQuit == "y")
                        repeat = true;
                    else
                        repeat = false;
                }

            } while (repeat);

            Console.WriteLine("\nThank you for banking with us!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
