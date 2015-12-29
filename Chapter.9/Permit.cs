namespace Chapter._9
{
	public class Permit
	{
		public PermitNotice Notice { get; private set; }
		protected bool _isValid;

		public Permit(PermitNotice notice)
		{
			Notice = notice;
			_isValid = false;
		}

		public Permit()
		{
			_isValid = false;
		}

		public bool IsValid()
		{
			return _isValid;
		}

		public void Validate()
		{
			
		}
	}
}