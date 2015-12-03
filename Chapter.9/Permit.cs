namespace Chapter._9
{
	public class Permit
	{
		public PermitNotice Notice { get; private set; }

		public Permit(PermitNotice notice)
		{
			Notice = notice;
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