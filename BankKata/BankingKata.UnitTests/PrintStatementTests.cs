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

		[Fact]
		public void AccountShould_BeAbleToPrintTransactionsReport()
		{
			Account account = new Account();

			account.Deposit(100);

			string actualReport = account.PrintStatement();
			string expectedReport = string.Format(ReportFormat, DateTime.Today.ToString("dd.MM.yyyy"), 100, 100);

			Assert.Equal(expectedReport, actualReport);
		}
	}
}
