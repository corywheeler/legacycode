namespace Chapter._9
{
	public class Permit
	{
		private readonly PermitNotice _notice;

		public Permit(PermitNotice notice)
		{
			_notice = notice;
		}

		public bool IsValid()
		{
			return true;
		}

		public void Validate()
		{
			
		}
	}
}