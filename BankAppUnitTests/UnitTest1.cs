using System;
using BankApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAppUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAccountCreation_ReturnsCorrectBalance()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.getBalance();
            string name = account.GetAccountHolderName();
            long acctNum = account.GetAccountNumber();

            //assert
            Assert.AreEqual(bal, 100);
            Assert.AreEqual(name, "Jamie");
            Assert.AreEqual(acctNum, 1111);
        }

        [TestMethod]
        public void TestAddInterest_ReturnsCorrectBalance()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            account.ChargeInterest();
            double bal = account.getBalance();

            //assert
            Assert.AreEqual(bal, 120);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_PAY_INTEREST_ON_ZERO)]
        public void TestAddInterest_ThrowsExceptionWhenBalanceIsZeroOrNeg()
        {
            //arrange
            BankAccount account = new BankAccount(1111, -10, "Jamie");

            //act
            account.ChargeInterest();
        }

        [TestMethod]
        public void TestMakeDeposit_ReturnsCorrectBalance()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.Deposit(100);

            //assert
            Assert.AreEqual(bal, 200);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_DEPOSIT_NEGATIVE)]
        public void TestMakeDeposit_ThrowsExceptionWhenAmountIsZeroOrNeg()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.Deposit(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_DEPOSIT_MORE_THAN_MAX)]
        public void TestMakeDeposit_ThrowsExceptionWhenDepositIsOverMaxAmount()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.Deposit(100000);
        }

        [TestMethod]
        public void TestMakeWithdrawal_ReturnsCorrectBalance()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.Withdraw(100);

            //assert
            Assert.AreEqual(bal, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_WITHDRAW_MORE_THAN_AVALIABLE)]
        public void TestMakeWithdrawal_ThrowsExceptionAttemptToWithdrawMoreThanBalance()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100, "Jamie");

            //act
            double bal = account.Withdraw(1000);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_WITHDRAW_MORE_THAN_MAX)]
        public void TestMakeWithdrawal_ThrowsExceptionAttemptToWithdrawMoreThanTransactionLimit()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100000000, "Jamie");

            //act
            double bal = account.Withdraw(100000);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception), CustomStrings.CANNOT_WITHDRAW_NEGATIVE)]
        public void TestMakeWithdrawal_ThrowsExceptionAttemptToWithdrawNegOrZero()
        {
            //arrange
            BankAccount account = new BankAccount(1111, 100000000, "Jamie");

            //act
            double bal = account.Withdraw(-100000);
        }
    }
}
