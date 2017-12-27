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

		[Theory]
		[InlineData(100, 200)]
		[InlineData(500, 300)]
		public void AccountShould_HaveBalanceDecreasedByTotalAmount_WhenYouMultipleWithdraw(int amount1, int amount2)
		{
			Account account = new Account();

			account.Withdraw(amount1);
			account.Withdraw(amount2);

			Assert.Equal(-(amount1 + amount2), account.Balance);
		}

		[Fact]
		public void AccountShould_NotAllowNegativeWitdraws()
		{
			Account account = new Account();

			Assert.Throws<ArgumentException>(() => account.Withdraw(-100));
		}
	}
}
