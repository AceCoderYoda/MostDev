#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.MsTest.CardTests.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace MostDev.MsTest
{
    public class BankAccount
    {
        private string name;

        public BankAccount(string name, double beginningBalance)
        {
            this.name = name;
            Balance = beginningBalance;
        }

        public double Balance { get; private set; }

        public void Debit(double amount)
        {
            if (amount > Balance) throw new ArgumentOutOfRangeException("amount");
            if (amount < 0) throw new ArgumentOutOfRangeException("amount");
            Balance -= amount;
        }
    }

    [TestClass]
    public class CardTests
    {
        // unit test code  
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            var beginningBalance = 11.99;
            var debitAmount = 4.55;
            var expected = 7.44;
            var account = new BankAccount("Mr. Bryan Cranston", beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert  
            var actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        // unit test code  
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WithValidAmount_UpdatesBalanceException()
        {
            // arrange  
            var beginningBalance = 11.99;
            var debitAmount = 44.55;
            var account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(debitAmount);
        }
    }
}