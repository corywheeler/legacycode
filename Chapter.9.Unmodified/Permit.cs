namespace Chapter._9.Unmodified
{
	public class Permit
	{
		private readonly PermitNotice _notice;
		protected bool _isValid;

		public Permit(PermitNotice notice)
		{
			_notice = notice;
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