using System;
using Xunit;

namespace BankingKata.UnitTests
{
	public class DepositTests
	{
		[Theory]
		[InlineData(100)]
		[InlineData(500)]
		public void AccountShould_HaveBalanceWithAmount_WhenYouDepositAmount(int amount)
		{
			Account account = new Account();

			account.Deposit(amount);

			Assert.Equal(amount, account.Balance);
		}
	}
}
