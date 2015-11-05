namespace Chapter._9
{
	public class CreditValidator
	{
		private readonly IRGHConnection _connection;
		private readonly CreditMaster _master;
		private readonly string _validatorId;

		public CreditValidator(IRGHConnection connection, CreditMaster master, string validatorID)
		{
			_connection = connection;
			_master = master;
			_validatorId = validatorID;
		}

		public Certificate ValidateCustomer(Customer customer)
		{
			return new Certificate();
		}

		public double GetValidationPercent()
		{
			return 100.0;
		}
	}
}
