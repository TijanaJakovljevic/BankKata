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
		private const string ReportHeaderFormat = "Date\t\tAmount\tBalance";
		private const string ReportRowFormat = "{0}\t\t{1}\t{2}";

		[Theory]
		[InlineData(100)]
		[InlineData(300)]
		public void AccountShould_BeAbleToPrintTransactionsReportForOneDeposit(int amount)
		{
			Account account = new Account();

			account.Deposit(amount);

			string actualReport = account.PrintStatement();
			string expectedReport = ReportHeaderFormat;
			expectedReport += "\n" + string.Format(ReportRowFormat, DateTime.Today.ToString("dd.MM.yyyy"), amount, amount);

			Assert.Equal(expectedReport, actualReport);
		}

		[Fact (Skip = "not implemented yet")]
		public void AccountShould_BeAbleToPrintTransactionsReportForMultipleDeposits()
		{
			Account account = new Account();

			account.Deposit(100);
			account.Deposit(200);

			string actualReport = account.PrintStatement();

			string expectedReport = ReportHeaderFormat;
			expectedReport += "\n" + string.Format(ReportRowFormat, DateTime.Today.ToString("dd.MM.yyyy"), 100, 100);
			expectedReport += "\n" + string.Format(ReportRowFormat, DateTime.Today.ToString("dd.MM.yyyy"), 200, 300);

			Assert.Equal(expectedReport, actualReport);
		}
	}
}
