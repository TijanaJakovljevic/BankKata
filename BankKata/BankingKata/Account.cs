namespace BankingKata
{
	public class Account
	{
		public int Balance { get; private set; }

		public void Deposit(int amount)
		{
			Balance += amount;
		}
	}
}
