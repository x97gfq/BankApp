using System;

namespace BankApp
{
    /// <summary>
    /// Bank App
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(11111, 100.00, "Jamie");
            Console.WriteLine("Created a new account with balance: $100\n");
            
            //Deposit $100
            try
            {
                Console.WriteLine("\n\nDeposit $100");
                double newBalance = account.Deposit(100.00);
                Console.WriteLine("balance is $" + newBalance);
            }
            catch (Exception exc)
            {
                Console.WriteLine("***"+exc.Message);
            }

            //Withdraw $1000
            try
            {
                Console.WriteLine("\n\nWithdraw $1000");
                double newBalance = account.Withdraw(1000.00);
                Console.WriteLine("...balance is $" + newBalance);
            }
            catch (Exception exc)
            {
                Console.WriteLine("***" + exc.Message);
            }

            //Deposit $100,000
            try
            {
                Console.WriteLine("\n\nDeposit $100,000");
                double newBalance = account.Deposit(100000.00);
                Console.WriteLine("balance is $" + newBalance);
            }
            catch (Exception exc)
            {
                Console.WriteLine("***" + exc.Message);
            }

            //Withdraw $100
            try
            {
                Console.WriteLine("\n\nWithdraw $100");
                double newBalance = account.Withdraw(100.00);
                Console.WriteLine("...balance is $" + newBalance);
            }
            catch (Exception exc)
            {
                Console.WriteLine("***" + exc.Message);
            }

            Console.WriteLine("");
            Console.WriteLine("\n\npress any key...");
            Console.ReadKey();
        }
    }
}
