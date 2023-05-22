using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
        public BankAccount()
        {
        }

        private double balance = 0.00;
		internal int Pin { get; set; }

		public bool CheckPin(int pinInput)
		{
			if(pinInput == Pin)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void SetPin(int newPin)
		{
			Pin = newPin;
		}

		public void Deposit(double deposit)
		{
			balance += deposit;
		}

		public double GetBalance()
		{
			return balance;
		}

		public void Withdraw(double withdraw)
		{
			if(balance >= withdraw)
			{
                balance -= withdraw;
            }
			else
			{
				Console.WriteLine("The balance is too low.");
			}
        }
	}
}

