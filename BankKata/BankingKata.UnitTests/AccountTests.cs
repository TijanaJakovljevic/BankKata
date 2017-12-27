using System;
using Xunit;

namespace BankingKata.UnitTests
{
	public class AccountTests
	{
		private const string ReportHeaderFormat = "Date\t\tAmount\tBalance";
		private const string ReportRowFormat = "{0}\t\t{1}\t{2}";

		[Fact]
		public void Should_HaveCorrectBalance_WhenYouDoIntermixedDepositsAndWithdraws()
		{
			Account account = new Account();

			account.Deposit(100);
			account.Deposit(200);
			account.Withdraw(150);
			account.Deposit(200);
			account.Withdraw(50);

			Assert.Equal(300, account.Balance);
		}

		[Fact]
		public void Should_PrintCorrectStatement()
		{
			Account account = new Account();

			account.Deposit(500);
			account.Withdraw(100);

			string actualReport = account.PrintStatement();

			string expectedReport = ReportHeaderFormat;
			expectedReport += "\n" + string.Format(ReportRowFormat, DateTime.Today.ToString("dd.MM.yyyy"), 500, 500);
			expectedReport += "\n" + string.Format(ReportRowFormat, DateTime.Today.ToString("dd.MM.yyyy"), -100, 400);


			Assert.Equal(expectedReport, actualReport);
		}
	}
}
