using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingKata.UnitTests
{
	public class WithdrawTests
	{
		[Fact]
		public void AccountShould_HaveBalanceDecreasedBy100_WhenYouWithdraw100()
		{
			Account account = new Account();

			account.Withdraw(100);

			Assert.Equal(-100, account.Balance);
		}
	}
}
