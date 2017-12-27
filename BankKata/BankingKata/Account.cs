using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			StringBuilder reportBuilder = new StringBuilder();
			reportBuilder.Append("Date\t\tAmount\tBalance");
			_transactions.ForEach(trans => reportBuilder.Append("\n" + trans.Print()));

			return reportBuilder.ToString();
		}
	}
}