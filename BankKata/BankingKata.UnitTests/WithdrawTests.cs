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
		[Theory]
		[InlineData(100)]
		[InlineData(200)]
		public void AccountShould_HaveBalanceDecreasedByAmount_WhenYouWithdrawAmount(int amount)
		{
			Account account = new Account();

			account.Withdraw(amount);

			Assert.Equal(-amount, account.Balance);
		}
	}
}
