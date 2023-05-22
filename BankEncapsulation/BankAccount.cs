using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
        public BankAccount()
        {
        }

        private double balance = 0.00;
		private int _pin;
		public int Pin
		{
			get
			{
				return _pin;
			}
			set
			{
				_pin = value;
			}
		}
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

