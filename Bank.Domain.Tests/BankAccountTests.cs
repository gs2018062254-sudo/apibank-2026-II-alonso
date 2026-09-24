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

            Assert.AreEqual(expected, actual,0.001);
        }


        // ACTIVIDAD 1
        [Test]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 10;
            double creditAmount = 5;
            double expected = 15;

            BankAccount account =
                new BankAccount("Alumno", beginningBalance);


            account.Credit(creditAmount);


            Assert.AreEqual(expected, account.Balance);
        }

    }
}