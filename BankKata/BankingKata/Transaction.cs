using System;

namespace BankingKata
{
	public class Transaction
	{
		public DateTime Date { get; }
		public int OldBalance { get; }
		public int NewBalance { get; }

		public Transaction(DateTime date, int oldBalance, int newBalance)
		{
			Date = date;
			OldBalance = oldBalance;
			NewBalance = newBalance;
		}

		public string Print()
		{
			return $"{Date:dd.MM.yyyy}\t\t{NewBalance - OldBalance}\t{NewBalance}";
		}
	}
}
