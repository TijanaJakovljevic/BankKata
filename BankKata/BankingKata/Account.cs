using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace BankingKata
{
	public class Account
	{
		private readonly List<Transaction> _transactions = new List<Transaction>();

		public int Balance => _transactions.Any() ? _transactions.Last().NewBalance : 0;

		public void Deposit(int amount)
		{
			if (amount < 0)
			{
				throw new ArgumentException();
			}

			int oldBalance = _transactions.Any() ? _transactions.Last().NewBalance : 0;
			_transactions.Add(new Transaction(DateTime.Today, oldBalance, oldBalance + amount));
		}

		public void Withdraw(int amount)
		{
			if (amount < 0)
			{
				throw new ArgumentException();
			}

			int oldBalance = _transactions.Any() ? _transactions.Last().NewBalance : 0;
			_transactions.Add(new Transaction(DateTime.Today, oldBalance, oldBalance - amount));
		}

		public string PrintStatement()
		{
			string ReportFormat = "Date\t\tAmount\tBalance\n{0}\t\t{1}\t{2}";
			return string.Format(ReportFormat, DateTime.Today.ToString("dd.MM.yyyy"), Balance, Balance);
		}
	}
}