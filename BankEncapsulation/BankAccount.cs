using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
        public BankAccount()
        {
        }

        private double balance = 0.00;

		public void Deposit(double deposit)
		{
			balance += deposit;
		}

		public double GetBalance()
		{
			return balance;
		}
	}
}

