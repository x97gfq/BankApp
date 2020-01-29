using System;

namespace BankApp
{
    /// <summary>
    /// BankAccount
    /// </summary>
    public class BankAccount
    {
        //constants
        private const double RATE = 0.20;  // interest rate of 10%
        private const double MAX_AMOUNT = 10000.00; // $10000 max deposit

        //attributes
        private long acctNumber;
        private double balance;
        private String name;

        /// <summary>
        /// BankAccount Constructor
        /// </summary>
        /// <param name="acctNum"></param>
        /// <param name="bal"></param>
        /// <param name="nme"></param>
        public BankAccount(long acctNum, double bal, String nme)
        {
            acctNumber = acctNum;
            balance = bal;
            name = nme;
        }

        /// <summary>
        /// GetBalance
        /// </summary>
        /// <returns>balance</returns>
        public double getBalance()
        {
            return balance;
        }

        /// <summary>
        /// ChargeInterest
        /// </summary>
        public void ChargeInterest()
        {
            if (balance <= 0)
            {
                throw new Exception(CustomStrings.CANNOT_PAY_INTEREST_ON_ZERO);
            }
            balance = balance + (RATE * 100);
        }

        /// <summary>
        /// Deposit
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception(CustomStrings.CANNOT_DEPOSIT_NEGATIVE);
            }
            if (amount > MAX_AMOUNT)
            {
                throw new Exception(CustomStrings.CANNOT_DEPOSIT_MORE_THAN_MAX);
            }
            balance = balance + amount;
            return balance;
        }

        /// <summary>
        /// Withdraw
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception(CustomStrings.CANNOT_WITHDRAW_NEGATIVE);
            }
            if (amount > MAX_AMOUNT)
            {
                throw new Exception(CustomStrings.CANNOT_WITHDRAW_MORE_THAN_MAX);
            }
            if (amount > balance)
            {
                throw new Exception(CustomStrings.CANNOT_WITHDRAW_MORE_THAN_AVALIABLE);
            }
            balance = balance - amount;
            return balance;
        }

        /// <summary>
        /// GetAccountNumber
        /// </summary>
        /// <returns></returns>
        public long GetAccountNumber()
        {
            return acctNumber;
        }

        /// <summary>
        /// GetAccountHolderName
        /// </summary>
        /// <returns></returns>
        public string GetAccountHolderName()
        {
            return name;
        }
    }
}
