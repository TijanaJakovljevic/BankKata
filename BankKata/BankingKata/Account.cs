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

		public void Withdraw(int amount)
		{
			if (amount < 0)
			{
				throw new ArgumentException();
			}

			Balance -= amount;
		}

		public string PrintStatement()
		{
			string ReportFormat = "Date\t\tAmount\tBalance\n{0}\t\t{1}\t{2}";
			return string.Format(ReportFormat, DateTime.Today.ToString("dd.MM.yyyy"), 100, 100);
		}
	}
}