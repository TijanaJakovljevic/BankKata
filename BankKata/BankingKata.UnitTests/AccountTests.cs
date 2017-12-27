using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingKata.UnitTests
{
	public class AccountTests
	{
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
	}
}
