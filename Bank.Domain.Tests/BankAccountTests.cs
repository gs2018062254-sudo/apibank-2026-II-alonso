using Bank.Domain.Models;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account =
                new BankAccount("Bryan Walton", beginningBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;

            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 10.00;
            double creditAmount = 5.00;
            double expected = 15.00;

            BankAccount account =
                new BankAccount("Bryan Walton", beginningBalance);

            account.Credit(creditAmount);

            double actual = account.Balance;

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}