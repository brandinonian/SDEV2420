using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace M1BankingAccount
{
    [TestClass]
    public class BankAccountTests
    {
        [DataRow(1000, 5, 500, 495)]
        [DataRow(1500, 0, 250, 1250)]
        [DataRow(1500, 0, 500, 1000)]
        [DataRow(3000, 5.50, 505, 2489.50)]
        [DataRow(5000, 2.75, 1500, 3497.25)]
        [DataRow(500, 0, 600, 500)] // amount too high
        [DataRow(0, 0, 500, 0)] // amount too high
        [DataRow(500, 5, 500, 500)] // amount + fee too high
        [DataRow(1000, 500, 1000, 1000)] // amount + fee too high
        [DataTestMethod]
        public void TestWithdraw(double Balance, double Fee, double amount, double result)
        {
            BankAccount account = new BankAccount(Balance, Fee);
            account.Withdraw(amount);
            Assert.AreEqual(result, account.Balance, 0.00);
        }

        [DataRow(1000, 5, 500, 1495)]
        [DataRow(500, 0, 5000, 5500)]
        [DataRow(1500, 10, 200, 1690)]
        [DataRow(3000, 1.50, 400, 3398.50)]
        [DataRow(2500, 5.75, 500, 2994.25)]
        [DataTestMethod]
        public void TestDeposit(double Balance, double Fee, double amount, double result)
        {
            BankAccount account = new BankAccount(Balance, Fee);
            account.Deposit(amount);
            Assert.AreEqual(result, account.Balance, 0.00);
        }
    }
}
