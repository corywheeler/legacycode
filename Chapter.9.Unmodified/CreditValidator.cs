namespace Chapter._9.Unmodified
{
	class CreditValidator
	{
		private readonly RGHConnection _connection;
		private readonly CreditMaster _master;
		private readonly string _validatorId;

		public CreditValidator(RGHConnection connection, CreditMaster master, string validatorID)
		{
			_connection = connection;
			_master = master;
			_validatorId = validatorID;
		}
	}
}
