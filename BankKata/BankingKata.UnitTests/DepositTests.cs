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

		[Theory]
		[InlineData(100, 500)]
		[InlineData(500, 700)]
		public void AccountShould_HaveBalanceIncreasedByTotalAmount_WhenYouDoMultipleDeposits(int amount1, int amount2)
		{
			Account account = new Account();

			account.Deposit(amount1);
			account.Deposit(amount2);

			Assert.Equal(amount1 + amount2, account.Balance);
		}

		[Fact]
		public void AccountShould_NotAllowNegativeDeposits()
		{
			Account account = new Account();

			Assert.Throws<ArgumentException>(() => account.Deposit(-100));
		}
	}
}
