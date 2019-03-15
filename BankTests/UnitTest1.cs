using System;
using BankAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{

    //Manpreet singh sidhu C0726407
    //Arshdeep singh brar C0730228
    [TestClass]
    public class bankaccounttests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.49;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. bryan walton", beginningBalance);
            //Act
            account.Debit(debitAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}