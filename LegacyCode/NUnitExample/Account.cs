namespace Bank
{
	public class Account
	{
		private decimal balance;
		private decimal minimumBalance = 10m;

		public void Deposit(decimal amount)
		{
			balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			balance -= amount;
		}

		public void TransferFunds(Account destination, decimal amount)
		{
			if (balance - amount < minimumBalance)
				throw new InsufficientFundsException();

			destination.Deposit(amount);

			Withdraw(amount);
		}

		public decimal Balance
		{
			get { return balance; }
		}

		public decimal MinimumBalance
		{
			get { return minimumBalance; }
		}
	}
}