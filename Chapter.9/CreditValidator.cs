namespace Chapter._9
{
	public class CreditValidator
	{
		private readonly IRGHConnection _connection;
		private readonly CreditMaster _master;
		private readonly string _validatorId;
		private double _validationPercent;

		public CreditValidator(IRGHConnection connection, CreditMaster master, string validatorID)
		{
			_connection = connection;
			_master = master;
			_validatorId = validatorID;
		}

		public Certificate ValidateCustomer(Customer customer)
		{
			// This is just a stub. It should be returning the number of successful validate customer calls made
			// versus the number of unsuccessful ones. We are stubbing it for example purposes. Point being, when
			// calling ValidateCustomer, this value should get set, and be testable by calling GetValidationPercent.
			_validationPercent = 100.0;

			return new Certificate();
		}

		public double GetValidationPercent()
		{
			return _validationPercent;
		}
	}
}
