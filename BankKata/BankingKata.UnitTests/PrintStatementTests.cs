using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingKata.UnitTests
{
	public class PrintStatementTests
	{
		private const string ReportFormat = "Date\t\tAmount\tBalance\n{0}\t\t{1}\t{2}";

		[Theory]
		[InlineData(100)]
		[InlineData(300)]
		public void AccountShould_BeAbleToPrintTransactionsReport(int amount)
		{
			Account account = new Account();

			account.Deposit(amount);

			string actualReport = account.PrintStatement();
			string expectedReport = string.Format(ReportFormat, DateTime.Today.ToString("dd.MM.yyyy"), amount, amount);

			Assert.Equal(expectedReport, actualReport);
		}
	}
}
