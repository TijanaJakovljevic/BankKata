using System;

namespace BankingKata
{
	public class Account
	{
		public int Balance { get; private set; }

		public void Deposit(int amount)
		{
			if (amount < 0)
			{
				throw new ArgumentException();
			}

			Balance += amount;
		}
	}
}
